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
		
		void Update(string Id, OwnedCarModel updatedModel);
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
				UserId = currentUserService.UserId(),
				ManufacturedDate = model.ManufacturedDate,
				Nickname = model.Nickname
			};

			Context.OwnedCars.Add(car);
			Context.SaveChanges();
			
			Context.MileageRecordings.Add(new MileageRecordingDto() {
				Mileage = "0",
				RecordingDate = model.ManufacturedDate,
				OwnedCarId = car.Id
			});
			if(model.CurrentMileage.HasValue) {
				Context.MileageRecordings.Add(new MileageRecordingDto() {
					Mileage = model.CurrentMileage.Value.ToString(),
					RecordingDate = DateTime.UtcNow,
					OwnedCarId = car.Id
				});
			}
			
			Context.SaveChanges();
			
			return car.Id;
		}

		public void Delete(string Id)
		{
			var userId = this.currentUserService.UserId();
			var cars = this.Context.OwnedCars.Where(x=>x.Vin == Id);
			var ownedCar = cars
				.FirstOrDefault(x => x.UserId == userId);
			var Recordings = Context.MileageRecordings.Where(x=>x.OwnedCarId == ownedCar.Id);
			Context.MileageRecordings.RemoveRange(Recordings);
			Context.OwnedCars.Remove(ownedCar);
			Context.SaveChanges();
		}

		public OwnedCarModel Get(string Vin)
		{
			var userId = this.currentUserService.UserId();
			var ownedCar = Context.OwnedCars.FirstOrDefault(x => x.Vin == Vin/* && x.UserId == userId*/);
			if(ownedCar == null)
				throw new KeyNotFoundException("Coult not find Car");
			var carModel = this.vinService.GetCar(ownedCar.Vin);
			ownedCar.MileageRecordings = Context.MileageRecordings.Where(x=>x.OwnedCarId == ownedCar.Id).ToList();
			
			var result = new OwnedCarModel()
			{
				Base = carModel,
				Vin = ownedCar.Vin,
				Mileage = ownedCar.MileageRecordings?.OrderByDescending(x => x.RecordingDate).FirstOrDefault()?.Mileage ?? "0",
				Nickname = ownedCar.Nickname??""
			};
			
			return result;
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

		public void Update(string Id, OwnedCarModel updatedModel)
		{
			var car = Context.OwnedCars.FirstOrDefault(x=>x.Vin == Id);
			car.Nickname = updatedModel.Nickname;
			Context.SaveChanges();
		}
	}
}
