using CoreApp.Models.Generic;
using CoreApp.Models.Repositories.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models.Vehicle
{
	public class CarModel
	{
		public string ManufacturerId;
		public ManufacturerModel Manufacturer;
		public string Vin;
		public string CountryId;
		public CountryModel CountryOfOrigin;
	}
}
