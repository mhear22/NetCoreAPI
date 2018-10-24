using CoreApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CoreAppTests.Tests.Services
{
	public class VinServiceTests : ServiceTestBase<IVinService>
	{
		[Fact]
		public void CorollaCheck()
		{
			var result = Service.GetCar("6T154AEA10D326365");

			Assert.NotNull(result);
			Assert.NotNull(result.ManufacturerId);
			Assert.Equal("Toyota",result.Manufacturer.Name);
			Assert.Equal("Australia", result.CountryOfOrigin.Name);
		}

		[Fact]
		public void Nissan240Check()
		{
			var result = Service.GetCar("JN1MS36P0MW002130");

			Assert.NotNull(result);
			Assert.NotNull(result.ManufacturerId);
			Assert.Equal("Nissan", result.Manufacturer.Name);
			Assert.Equal("Japan", result.CountryOfOrigin.Name);
		}
	}
}
