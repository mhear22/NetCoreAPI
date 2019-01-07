using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;

namespace CoreApp.Services
{
	public interface IComponentService
	{
		void AddServiceItem(string Vin, ServiceItem serviceItem);
		void DeleteServiceItem(string ServiceItemId);
		List<ServiceItem> GetForVin(string Vin);
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
			var car = Context.OwnedCars.FirstOrDefault(x => x.Vin == Vin && x.UserId == userId);

			return car.ServiceReminders.Select(x =>
			{
				return new ServiceItem()
				{
					RepeatingFrequency = x.RepeatingFigure,
					RepeatingTypeId = x.RepeatingTypeId,
					ServiceTypeId = x.ServiceTypeId,
					Description = x.Description,
					Id = x.Id
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
	}

	public class ServiceItem
	{
		public string Id;
		public string ServiceTypeId;
		public string Description;
		public string RepeatingTypeId;
		public string RepeatingFrequency;
		
	}
}
