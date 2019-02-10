using CoreApp.Models.Vehicle;
using CoreApp.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CoreApp.Services
{
	public interface IRepeatingItemService
	{
		void AddRepeatingItem(AddRepeatingSettings model);
		void Delete(string Id);

		double RepeatingHealth(string ReminderId);
	}

	public class RepeatingItemService : ServiceBase, IRepeatingItemService
	{
		private IMileageService mileageService;
		public RepeatingItemService(
			IContext context,
			IMileageService mileageService
		) : base(context)
		{
			this.mileageService = mileageService;
		}

		public void AddRepeatingItem(AddRepeatingSettings model)
		{
			var reminder = Context.ServiceReminders.FirstOrDefault(x => x.Id == model.Id);

			reminder.RepeatingTypeId = model.TypeId;
			reminder.RepeatingFigure = model.Amount;
			reminder.RepeatOffsetDate = model.Offset;

			Context.SaveChanges();
		}

		public void Delete(string Id)
		{
			var reminder = Context.ServiceReminders.FirstOrDefault(x => x.Id == Id);

			reminder.RepeatingTypeId = null;
			reminder.RepeatingFigure = null;

			Context.SaveChanges();
		}

		public double RepeatingHealth(string ReminderId)
		{
			var reminder = Context.ServiceReminders
				.Include(x=>x.OwnedCar)
				.Select(x=> new
				{
					dto = x,
					LastChange = x.Receipts.OrderByDescending(z=>z.CurrentMiles).FirstOrDefault()
				})
				.FirstOrDefault(x => x.dto.Id == ReminderId);

			var estimatedMileage = this.mileageService.EstimateCurrent(reminder.dto.OwnedCar.Vin);
			var mileageDouble = double.Parse(estimatedMileage);

			var CurrentMiles = reminder.LastChange?.CurrentMiles ?? "0";


			var ServicePeriod = 0.0;
			try
			{
				ServicePeriod = double.Parse(reminder.dto.RepeatingFigure);
			}
			catch { return 100; }

			var timeSinceChange = (mileageDouble - double.Parse(CurrentMiles));

			var Health = 100 - ((timeSinceChange / ServicePeriod) * 50);
			if (Health < 0)
				Health = 0;
			return Health;
		}
	}
}