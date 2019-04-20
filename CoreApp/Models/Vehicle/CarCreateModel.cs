using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models.Vehicle
{
	public class CarCreateModel
	{
		public string Vin;
		public string Nickname;
		public DateTime ManufacturedDate;
		public float? CurrentMileage;
		public DateTime NextService;
	}
}
