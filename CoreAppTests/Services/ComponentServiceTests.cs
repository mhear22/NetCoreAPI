using CoreApp.Models.Vehicle;
using CoreApp.Repositories;
using CoreApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CoreAppTests.Services
{
	public class ComponentServiceTests: ServiceTestBase<IComponentService>
	{
		private ICarService carService;
		public ComponentServiceTests()
		{
			carService = Get<ICarService>();
		}

		[Fact]
		public void AddItemToCorolla()
		{
			var car = carService.AddCar(new CarCreateModel()
			{
				CurrentMileage = 100000,
				ManufacturedDate = DateTime.Now,
				Nickname = "Test Car",
				Vin = VinCollection.Corolla
			});

			Service.AddServiceItem(VinCollection.Corolla,new ServiceItem()
			{
				Description = "Test",
				RepeatingFrequency = "1000",
				RepeatingTypeId = RepeatTypeDto.Mileage,
				ServiceTypeId = ServiceTypeDto.OilChange
			});

			var ownedCar = Context.OwnedCars.FirstOrDefault();
			Assert.NotEmpty(ownedCar.ServiceReminders);
		}

		[Fact]
		public void GetServiceItems()
		{
			var car = carService.AddCar(new CarCreateModel()
			{
				CurrentMileage = 100000,
				ManufacturedDate = DateTime.Now,
				Nickname = "Test Car",
				Vin = VinCollection.Corolla
			});

			Service.AddServiceItem(VinCollection.Corolla, new ServiceItem()
			{
				Description = "Test",
				RepeatingFrequency = "1000",
				RepeatingTypeId = RepeatTypeDto.Mileage,
				ServiceTypeId = ServiceTypeDto.OilChange
			});

			var currentCar = Service.GetForVin(VinCollection.Corolla);

			Assert.NotEmpty(currentCar);
		}

		[Fact]
		public void DeleteServiceItem()
		{
			var car = carService.AddCar(new CarCreateModel()
			{
				CurrentMileage = 100000,
				ManufacturedDate = DateTime.Now,
				Nickname = "Test Car",
				Vin = VinCollection.Corolla
			});

			Service.AddServiceItem(VinCollection.Corolla, new ServiceItem()
			{
				Description = "Test",
				RepeatingFrequency = "1000",
				RepeatingTypeId = RepeatTypeDto.Mileage,
				ServiceTypeId = ServiceTypeDto.OilChange
			});

			var currentCar = Service.GetForVin(VinCollection.Corolla);

			Service.DeleteServiceItem(currentCar.FirstOrDefault().Id);

			var empty = Service.GetForVin(VinCollection.Corolla);
			Assert.Empty(empty);
		}
	}
}
