using CoreApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CoreAppTests.Services
{
	public class VinServiceTests : ServiceTestBase<IVinService>
	{
		[Fact]
		public void CorollaCheck()
		{
			var result = Service.GetCar(VinCollection.Corolla);

			Assert.NotNull(result);
			Assert.NotNull(result.ManufacturerId);
			Assert.Equal("Toyota",result.Manufacturer.Name);
			Assert.Equal("Australia", result.CountryOfOrigin.Name);
		}

		[Fact]
		public void Nissan240Check()
		{
			var result = Service.GetCar(VinCollection.Nissan240);

			Assert.NotNull(result);
			Assert.NotNull(result.ManufacturerId);
			Assert.Equal("Nissan", result.Manufacturer.Name);
			Assert.Equal("Japan", result.CountryOfOrigin.Name);
		}
	}
}
