using CoreApp.Models.Vehicle;
using CoreApp.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace CoreAppTests.Services
{
	public class CarSerivceTests : ServiceTestBase<ICarService>
	{
		[Fact]
		public void CorollaCarCheck()
		{
			var model = new CarCreateModel()
			{
				Vin = VinCollection.Corolla,
				Nickname = "Corolla"
			};
			
			var result = Service.AddCar(model);
			var CarModel = Service.Get(model.Vin);

			Assert.NotNull(result);
			Assert.NotNull(CarModel);
			Assert.Equal(model.Vin, CarModel.Vin);
			Assert.NotNull(CarModel.Base.Manufacturer);
			Assert.NotNull(CarModel.Base.CountryOfOrigin);
		}
	}
}
