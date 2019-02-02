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
	public class WorkItemServiceTests: ServiceTestBase<IWorkItemService>
	{
		[Fact]
		public void WorkItemAddItemWorks()
		{
			Get<ICarService>().AddCar(new CarCreateModel()
			{
				Vin = VinCollection.Corolla,
				CurrentMileage = 2000,
				ManufacturedDate = DateTime.Now,
				Nickname = "Corolla"
			});


			Service.AddItem(new AddWorkItem()
			{
				ServiceTypeId = ServiceTypeDto.Brakes,
				Vin = VinCollection.Corolla
			});

			var receipts = Context.ServiceReceipts.ToList();
			Assert.NotNull(receipts);
		}

		[Fact]
		public void WorkItemGetByVinWorks()
		{
			Get<ICarService>().AddCar(new CarCreateModel()
			{
				CurrentMileage = 2000,
				ManufacturedDate = DateTime.Now,
				Nickname = "Corolla",
				Vin = VinCollection.Corolla
			});

			Service.AddItem(new AddWorkItem()
			{
				ServiceTypeId = ServiceTypeDto.Brakes,
				Vin = VinCollection.Corolla
			});


			var results = Service.GetForVin(VinCollection.Corolla);

			Assert.NotNull(results);
		}
	}
}
