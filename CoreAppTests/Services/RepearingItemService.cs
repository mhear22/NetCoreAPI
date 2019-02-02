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
	public class RepearingItemService: ServiceTestBase<IRepeatingItemService>
	{
		private void SetupCar(string Vin)
		{
			Get<ICarService>().AddCar(new CarCreateModel()
			{
				CurrentMileage = 2000,
				ManufacturedDate = DateTime.Now,
				Nickname = "car",
				Vin = Vin
			});

			Get<IWorkItemService>().AddItem(new AddWorkItem()
			{
				Vin = Vin,
				ServiceTypeId = ServiceTypeDto.Brakes
			});
		}

		[Fact]
		public void AddingRepeatingWorks()
		{
			SetupCar(VinCollection.Corolla);

			Service.AddRepeatingItem(new AddRepeatingSettings()
			{
				Amount = "1",
				Id = Context.ServiceReminders.First().Id,
				TypeId = RepeatTypeDto.Age
			});

			var rem = Context.ServiceReminders.FirstOrDefault();
			Assert.NotNull(rem.RepeatingTypeId);
			Assert.NotNull(rem.RepeatingFigure);
		}
	}
}
