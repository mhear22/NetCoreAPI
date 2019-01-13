using CoreApp.Models.Vehicle;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace CoreAppTests.Fixtures
{
	class VinFixture : BaseFixture
	{
		public VinFixture(HttpClient client)
			: base(client)
		{ }

		public CarModel GetCar(string Vin)
		{
			var request = Get($"/vin/{Vin}");

			if (request.StatusCode != HttpStatusCode.OK)
				return null;

			var result = JsonConvert.DeserializeObject<CarModel>(
				request.Content.ReadAsStringAsync().Result
			);

			return result;
		}
	}
}
