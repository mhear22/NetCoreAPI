using CoreApp.Models.Vehicle;
using CoreApp.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreApp.Services
{
	public interface IWorkItemService
	{
		void AddItem(AddWorkItem model);
		void Delete(string Id);
		List<ReceiptModel> GetForVin(string Vin);
	}

	public class WorkItemService : ServiceBase, IWorkItemService
	{
		private IMileageService mileageService;
		private ICurrentUserService currentUserService;

		public WorkItemService(
			IContext context,
			IMileageService mileageService,
			ICurrentUserService currentUserService
		) : base(context)
		{
			this.currentUserService = currentUserService;
			this.mileageService = mileageService;
		}

		public void AddItem(AddWorkItem model)
		{
			var car = Context.OwnedCars
				.Include(x=>x.ServiceReminders)
				.FirstOrDefault(x => x.Vin == model.Vin);

			var Item = car.ServiceReminders.FirstOrDefault(x => x.ServiceTypeId == model.ServiceTypeId);

			if (Item == null)
			{
				Item = new ServiceReminderDto()
				{
					OwnedCarId = car.Id,
					Id = Guid.NewGuid().ToString(),
					ServiceTypeId = model.ServiceTypeId
				};
				Context.ServiceReminders.Add(Item);
				Context.SaveChanges();
			}

			var receipt = new ServiceReceiptDto()
			{
				CurrentMiles = mileageService.EstimateCurrent(car.Vin),
				Id = Guid.NewGuid().ToString(),
				CreatedDate = DateTime.UtcNow,
				ServiceReminderId = Item.Id
			};

			Context.ServiceReceipts.Add(receipt);
			Context.SaveChanges();
		}

		public void Delete(string Id)
		{
			var item = Context.ServiceReminders
				.Include(x=>x.OwnedCar)
				.Include(x=>x.OwnedCar.Owner)
				.FirstOrDefault(x => x.Id == Id);

			var currentUser = this.currentUserService.UserId();

			if (item.OwnedCar.UserId == currentUser)
			{
				Context.ServiceReminders.Remove(item);
				Context.SaveChanges();
			}
			else
				throw new ArgumentException("Can not find this service Item");
		}

		public List<ReceiptModel> GetForVin(string Vin)
		{
			var Car = Context.OwnedCars
				.Include(x=>x.ServiceReminders)
				.FirstOrDefault(x => x.Vin == Vin);

			var Ids = Car.ServiceReminders.Select(x => x.Id).ToList();
			return Context.ServiceReminders
				.Include(x => x.RepeatingType)
				.Include(x => x.ServiceType)
				.Where(x => Ids.Contains(x.Id))
				.ToList()
				.Select(x => new ReceiptModel()
				{
					ServiceType = x.ServiceType.Name,
					RepeatFrequency = x.RepeatingFigure,
					RepeatType = x.RepeatingType?.Name,
					Id = x.Id
				})
				.ToList();
		}
	}
}