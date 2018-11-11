using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Models.Generic;
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
		Page<OwnedCarModel> GetForUser(string UserId);
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
			var ownedCar = Context.OwnedCars.FirstOrDefault(x => x.Vin == Id);
			var carModel = this.vinService.GetCar(ownedCar.Vin);

			return new OwnedCarModel()
			{
				Base = carModel,
				Vin = ownedCar.Vin,
				Mileage = ownedCar.MileageRecordings?.OrderByDescending(x => x.RecordingDate).FirstOrDefault()?.Mileage ?? "0",
				Nickname = ownedCar.Nickname??""
			};
		}

		public Page<OwnedCarModel> GetForUser(string UserId)
		{
			var results = Context.OwnedCars
				.Where(x => x.UserId == UserId)
				.ToList()
				.Select(x =>
				{

					return new OwnedCarModel()
					{
						Base = this.vinService.GetCar(x.Vin),
						Vin = x.Vin,
						Mileage = x.MileageRecordings?.OrderByDescending(z => z.RecordingDate).FirstOrDefault()?.Mileage ?? "0",
						Nickname = x.Nickname??""
					};
				})
				.ToList();

			return new Page<OwnedCarModel>()
			{
				Count = results.Count(),
				Items = results
			};
		}
	}
}
