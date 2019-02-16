using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using CoreApp.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CoreApp.Services
{
	public interface IReminderReportService
	{
		void BuildEmails();
	}

	public class ReminderReportService : ServiceBase, IReminderReportService
	{
		private IMileageService mileageService;
		private IEmailService emailService;

		public ReminderReportService(
			IContext context,
			IMileageService mileageService,
			IEmailService emailService,
		) : base(context)
		{
			this.mileageService = mileageService;
			this.emailService = emailService;
		}

		public async void BuildEmails()
		{
			var Vins = await Context.OwnedCars.Select(x => x.Vin).ToListAsync();
			Vins.ForEach(x =>
			{
				var estimate = this.mileageService.EstimateCurrent(x);
				var car = Context.OwnedCars.FirstOrDefault(z => z.Vin == x);

				var check = double.Parse(estimate);
				var normalLast = double.Parse(car.LastRecordingMileage ?? "0") + 1000d;

				if (normalLast < check)
				{
					var serviceItems = Context.ServiceReminders
					.Include(z => z.ServiceType)
					.Select(z => new ServiceReminderDto()
					{
						Receipts = z.Receipts.OrderByDescending(c => c.CurrentMiles).Take(1).ToList(),
						ServiceTypeId = z.ServiceTypeId,
						RepeatingTypeId = z.RepeatingTypeId,
						RepeatingFigure = z.RepeatingFigure,
						ServiceType = z.ServiceType
					}).ToList();

					var expiredArticles = serviceItems.Where(z =>
					{
						var lastrec = z.Receipts.FirstOrDefault();
						if (z.RepeatingTypeId == RepeatTypeDto.Age)
						{
							var span = DateTime.UtcNow - (lastrec?.CreatedDate ?? DateTime.MinValue);
							if (span.TotalDays / 365 > double.Parse(z.RepeatingFigure))
							{
								return true;
							}
							else
							{
								return false;
							}
						}
						else
						{
							var span = double.Parse(estimate) - double.Parse(lastrec?.CurrentMiles ?? "0.0");
							return span > double.Parse(z.RepeatingFigure);
						}
					}).ToList();
					if (expiredArticles.Any())
					{
						var reason = expiredArticles.Select(z => $"{z.ServiceType.Name} ").SelectMany(z => z).ToArray();

						try
						{
							var rsn = "These Parts are out of date: " + new string(reason);

							this.emailService.SendServiceEmail(x, rsn);
							car.LastRecordingMileage = estimate;
							Context.SaveChanges();
						}
						catch (Exception ex)
						{
							Console.WriteLine(ex.Message);
						}
					}
				}
			});


			var FirstVin = Vins.FirstOrDefault();
		}
	}
}
