using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Models.Repositories.Vehicle;
using CoreApp.Models.Vehicle;
using CoreApp.Repositories;

namespace CoreApp.Services
{
	public interface ICarService
	{
		string AddCar(CarCreateModel model);
		OwnedCarModel Get(string Id);
		void Delete(string Id);
	}

	public class CarService : ServiceBase, ICarService
	{
		private ICurrentUserService currentUserService;
		private IVinService vinService;

		public CarService(
			IContext context,
			ICurrentUserService currentUserService,
			IVinService vinService
		) : base(context)
		{
			this.vinService = vinService;
			this.currentUserService = currentUserService;
		}

		public string AddCar(CarCreateModel model)
		{
			var car = new OwnedCarDto()
			{
				Vin = model.Vin,
				UserId = currentUserService.UserId()
			};

			Context.OwnedCars.Add(car);
			Context.SaveChanges();
			return car.Id;
		}

		public void Delete(string Id)
		{
			var userId = this.currentUserService.UserId();
			var ownedCar = this.Context.OwnedCars
				.FirstOrDefault(x => x.Id == Id && x.UserId == userId );
			Context.OwnedCars.Remove(ownedCar);
			Context.SaveChanges();
		}

		public OwnedCarModel Get(string Id)
		{
			var ownedCar = Context.OwnedCars.FirstOrDefault(x => x.Id == Id);
			var carModel = this.vinService.GetCar(ownedCar.Vin);

			return new OwnedCarModel()
			{
				Base = carModel,
				Vin = ownedCar.Vin
			};
		}
	}
}
