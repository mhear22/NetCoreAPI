using CoreAppTests.Tests.Fixtures;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CoreAppTests.Tests.Actions
{
	public class VinControllerTests : TestBase
	{
		private VinFixture _vin;
		public VinControllerTests()
		{
			this._vin = new VinFixture(_client);
		}

		//[Fact]
		public void Vin_WithId_ReturnsOk()
		{
			var result = _vin.GetCar("6T154AEA10D326365");

			Assert.NotNull(result);
		}
	}
}
