using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Forms
{
	public class CarReport: ReportBase
	{
		private IMileageService mileageService;
		public CarReport(
			IContext Context,
			IMileageService mileageService
		) :base(Context)
		{
			this.mileageService = mileageService;
		}

		protected override object Execute() 
		{
			var vin = this.Get("vin");
			var car = Context.OwnedCars
				.Include(x=>x.ServiceReminders)
				.Include(x=>x.MileageRecordings)
				.FirstOrDefault(z=>z.Vin == vin);
			var estimatedMileage = mileageService.EstimateCurrent(vin);

			var mileageDouble = double.Parse(estimatedMileage);

			var serviceReminders = Context.ServiceReminders
					//.Where(x => x.OwnedCarId == car.Id)
					.Include(x => x.Receipts)
					.Include(x => x.ServiceType)
					.ToList().Select(x=> {
						var lastChange = x.Receipts?
							.OrderByDescending(z => z.CurrentMiles)
							.FirstOrDefault();

						var CurrentMiles = lastChange?.CurrentMiles ?? "0";

						var Health = 100.0;

						if(x.RepeatingFigure!= null)
						{
							var ServicePeriod = double.Parse(x.RepeatingFigure);
							var timeSinceChange = (mileageDouble - double.Parse(CurrentMiles));

							Health = 100 - ((timeSinceChange / ServicePeriod) * 50);
							if (Health < 0)
								Health = 0;
						}
						
						return new
						{
							x.Description,
							x.ServiceType?.Name,
							x.Id,
							CurrentMiles,
							LastChangeDate = lastChange?.CreatedDate,
							Health = Health.ToString("0.##"),
							HealthColor = (Health > 80) ? "green" : (Health > 50) ? "yellow" : "red",
							
						};
					}).ToList();

			var mileage = mileageService.GetGraphMileage(vin);
			var seperation = 100d/(double)mileage.Count();


			return new {
				domain = this.Domain,
				seperation,
				Car = car,
				Vin = car.Vin,
				ServiceReminders = serviceReminders,
				mileage = mileage.Select(x => {
					return new
					{
						x.Recording,
						x.Year,
						Percentage = double.Parse(x.Recording) / double.Parse(mileage.Last().Recording) * 100
					};
				}).ToList(),
				estimatedMileage
			};
		}
	}
}
