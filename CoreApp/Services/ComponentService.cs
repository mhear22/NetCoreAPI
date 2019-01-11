using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Models.Vehicle;
using CoreApp.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CoreApp.Services
{
	public interface IComponentService
	{
		void AddServiceItem(string Vin, ServiceItem serviceItem);
		void DeleteServiceItem(string ServiceItemId);
		List<ServiceItem> GetForVin(string Vin);

		ServiceItemModel GetPart(string Vin, string ServiceId);
		void CompleteWorkOnPart(string Vin, string ServiceId, PartCompleteModel model);
	}

	public class ComponentService : ServiceBase, IComponentService
	{
		private ICurrentUserService currentUserService;
		public ComponentService(
			IContext context,
			ICurrentUserService currentUserService
		) : base(context)
		{
			this.currentUserService = currentUserService;
		}


		public void AddServiceItem(string Vin, ServiceItem serviceItem)
		{
			var userId = currentUserService.UserId();
			var car = Context.OwnedCars.Where(x => x.UserId == userId).FirstOrDefault(x => x.Vin == Vin);
			var type = Context.ServiceTypes.FirstOrDefault(x => x.Id == serviceItem.ServiceTypeId);
			var repeat = Context.RepeatTypes.FirstOrDefault(x => x.Id == serviceItem.RepeatingTypeId);

			if (car == null || type == null || repeat == null)
				throw new ArgumentException("Could not find data");

			var model = new ServiceReminderDto()
			{
				Id = Guid.NewGuid().ToString(),
				RepeatingTypeId = repeat.Id,
				RepeatingFigure = serviceItem.RepeatingFrequency,
				OwnedCarId = car.Id,
				ServiceTypeId = type.Id,
				Description = serviceItem.Description
			};

			Context.ServiceReminders.Add(model);
			Context.SaveChanges();
		}

		public List<ServiceItem> GetForVin(string Vin)
		{
			var userId = currentUserService.UserId();
			var car = Context.OwnedCars
				.Include(x=>x.ServiceReminders)
				.FirstOrDefault(x => x.Vin == Vin && x.UserId == userId);

			var repeatingTypes = Context.RepeatTypes.ToList();
			var serviceTypes = Context.ServiceTypes.ToList();

			return car.ServiceReminders.Select(x =>
			{
				return new ServiceItem()
				{
					RepeatingFrequency = x.RepeatingFigure,
					RepeatingTypeId = x.RepeatingTypeId,
					ServiceTypeId = x.ServiceTypeId,
					Description = x.Description,
					Id = x.Id,
					RepeatingType = repeatingTypes.Where(z=>z.Id == x.RepeatingTypeId).FirstOrDefault().Name,
					ServiceType = serviceTypes.Where(z=>z.Id == x.ServiceTypeId).FirstOrDefault().Name,
				};
			}).ToList();

		}

		public void DeleteServiceItem(string ServiceItemId)
		{
			var reminder = Context.ServiceReminders.FirstOrDefault(x => x.Id == ServiceItemId);

			if (this.currentUserService.UserId() != reminder.OwnedCar.UserId)
				throw new UnauthorizedAccessException("Not allowed to delete");

			Context.ServiceReminders.Remove(reminder);
			Context.SaveChanges();
		}

		public ServiceItemModel GetPart(string Vin, string ServiceId)
		{
			var ownedCar = Context.OwnedCars
				.Include(x=>x.ServiceReminders)
				.FirstOrDefault(x => x.Vin == Vin);

			var ServiceComponent = Context.ServiceReminders
				.Where(x => x.OwnedCarId == ownedCar.Id)
				.Include(x=>x.Receipts)
				.FirstOrDefault(x => x.Id == ServiceId);

			var receipts = Context.ServiceReceipts
					.Where(x => x.ServiceReminderId == ServiceComponent.Id)
					.ToList();

			var result = new ServiceItemModel()
			{
				RepeatingFrequency = ServiceComponent.RepeatingFigure,
				RepeatingTypeId = ServiceComponent.RepeatingTypeId,
				ServiceTypeId = ServiceComponent.ServiceTypeId,
				Description = ServiceComponent.Description,
				Id = ServiceComponent.Id,
				RepeatingType = Context.RepeatTypes.FirstOrDefault(x => x.Id == ServiceComponent.RepeatingTypeId).Name,
				ServiceType = Context.ServiceTypes.FirstOrDefault(x => x.Id == ServiceComponent.ServiceTypeId).Name
			};

			var lastTime = receipts.OrderByDescending(x => x.CreatedDate).FirstOrDefault();

			result.LastServiceMileage = lastTime?.CurrentMiles ?? "0";
			result.LastServiceTime = lastTime?.CreatedDate;

			return result;
		}

		public void CompleteWorkOnPart(string Vin, string ServiceId, PartCompleteModel model)
		{
			var ownedCar = Context.OwnedCars.FirstOrDefault(x => x.Vin == Vin);
			var serviceItem = Context.ServiceReminders
				.Where(x => x.OwnedCarId == ownedCar.Id)
				.FirstOrDefault(x => x.Id == ServiceId);

			Context.ServiceReceipts.Add(new ServiceReceiptDto()
			{
				Id = Guid.NewGuid().ToString(),
				CreatedDate = DateTime.UtcNow,
				CurrentMiles = model.CurrentMiles,
				ServiceReminderId = serviceItem.Id
			});

			Context.SaveChanges();
		}
	}
}
