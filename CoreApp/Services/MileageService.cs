using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Models.Repositories.Vehicle;
using CoreApp.Models.Vehicle;
using CoreApp.Repositories;

namespace CoreApp.Services
{
	public interface IMileageService
	{
		void UpdateMileage(MileageModel model);
	}

	public class MileageService : ServiceBase, IMileageService
	{
		private ICurrentUserService currentUserService;
		public MileageService(
			IContext context,
			ICurrentUserService currentUserService
		) : base(context)
		{
			this.currentUserService = currentUserService;
		}
		
		public void UpdateMileage(MileageModel model)
		{
			var currentUser = this.currentUserService.CurrentUser();
			var OwnedCar = Context.OwnedCars.FirstOrDefault(x => x.Vin == model.Vin);

			if (OwnedCar.UserId != currentUser.Id)
				throw new UnauthorizedAccessException();

			if (OwnedCar == null)
				throw new ArgumentException("This Vin has not been added");

			var Mileage = float.Parse(model.Mileage);
			var LastMileage = OwnedCar.MileageRecordings.OrderByDescending(x => x.RecordingDate).FirstOrDefault();

			if (float.Parse(LastMileage.Mileage) > Mileage)
				throw new ArgumentException("Mileage is too low");

			OwnedCar.MileageRecordings.Add(new MileageRecordingDto()
			{
				Mileage = model.Mileage,
				OwnedCarId = OwnedCar.Id,
				RecordingDate = DateTime.UtcNow,
			});
			Context.SaveChanges();
		}
	}
}
