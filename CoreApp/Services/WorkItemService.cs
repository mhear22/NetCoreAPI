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
		string AddItem(AddWorkItem model);
		void Delete(string Id);
		List<ReceiptModel> GetForVin(string Vin);
		ReceiptModel Get(string Id);
		void CompleteWork(string Id, string CurrentMiles);
		List<ServiceReceiptModel> GetReceipts(string Id);
	}

	public class WorkItemService : ServiceBase, IWorkItemService
	{
		private IMileageService mileageService;
		private ICurrentUserService currentUserService;
		private IRepeatingItemService repeatingItemService;

		public WorkItemService(
			IContext context,
			IMileageService mileageService,
			ICurrentUserService currentUserService,
			IRepeatingItemService repeatingItemService
		) : base(context)
		{
			this.currentUserService = currentUserService;
			this.mileageService = mileageService;
			this.repeatingItemService = repeatingItemService;
		}

		public string AddItem(AddWorkItem model)
		{
			if (model.ServiceTypeId == null)
				throw new ArgumentException("Service Type is required");

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
			return Item.Id;
		}

		public void CompleteWork(string Id, string CurrentMiles)
		{
			var operation = Context.ServiceReminders
				.FirstOrDefault(x => x.Id == Id);

			Context.ServiceReceipts.Add(new ServiceReceiptDto()
			{
				CreatedDate = DateTime.UtcNow,
				Id = Guid.NewGuid().ToString(),
				CurrentMiles = CurrentMiles,
				ServiceReminderId = operation.Id
			});
			Context.SaveChanges();
		}

		public void Delete(string Id)
		{
			var item = Context.ServiceReminders
				.Include(x=>x.OwnedCar)
				.Include(x=>x.OwnedCar.Owner)
				.Include(x=>x.Receipts)
				.FirstOrDefault(x => x.Id == Id);

			var currentUser = this.currentUserService.UserId();

			if (item.OwnedCar.UserId == currentUser)
			{
				Context.ServiceReceipts.RemoveRange(item.Receipts);
				Context.ServiceReminders.Remove(item);
				Context.SaveChanges();
			}
			else
				throw new ArgumentException("Can not find this service Item");
		}

		public ReceiptModel Get(string Id)
		{
			var result = Context.ServiceReminders
				.Include(x => x.RepeatingType)
				.Include(x => x.ServiceType)
				.Include(x => x.Receipts)
				.Where(x => x.Id == Id)
				.ToList()
				.Select(x => new ReceiptModel()
				{
					ServiceTypeId = x.ServiceTypeId,
					ServiceType = x.ServiceType?.Name,
					RepeatFrequency = x.RepeatingFigure,
					RepeatType = x.RepeatingType?.Name,
					RepeatTypeId = x.RepeatingTypeId,
					Id = x.Id,
					Health = this.repeatingItemService.RepeatingHealth(x.Id),
					LastChange = x.Receipts?
						.OrderByDescending(z => z.CurrentMiles)
						.Select(z => new ServiceReceiptModel()
						{
							Date = z.CreatedDate,
							Mileage = z.CurrentMiles
						})
						.FirstOrDefault(),

				})
				.FirstOrDefault();
			return result;
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
				.Include(x => x.Receipts)
				.Where(x => Ids.Contains(x.Id))
				.ToList()
				.Select(x => new ReceiptModel()
				{
					ServiceTypeId = x.ServiceTypeId,
					ServiceType = x.ServiceType?.Name,
					RepeatFrequency = x.RepeatingFigure,
					RepeatType = x.RepeatingType?.Name,
					RepeatTypeId = x.RepeatingTypeId,
					Id = x.Id,
					Health = this.repeatingItemService.RepeatingHealth(x.Id),
					LastChange = x.Receipts?
						.OrderByDescending(z=>z.CurrentMiles)
						.Select(z=> new ServiceReceiptModel() {
							Date = z.CreatedDate,
							Mileage = z.CurrentMiles
						})
						.FirstOrDefault(),
					
				})
				.ToList();
		}

		public List<ServiceReceiptModel> GetReceipts(string Id)
		{
			return Context.ServiceReminders
				.Include(x=>x.Receipts)
				.FirstOrDefault(x => x.Id == Id).Receipts
				.Select(x => new ServiceReceiptModel()
			{
				Date = x.CreatedDate,
				Mileage = x.CurrentMiles
			}).ToList();
		}
		
	}
}