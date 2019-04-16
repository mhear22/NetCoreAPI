using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models.Vehicle
{
	public class ServiceItemModel
	{
		public string RepeatingFrequency;
		public string RepeatingTypeId;
		public string ServiceTypeId;
		public string Description;
		public string Id;
		public string RepeatingType;
		public string ServiceType;

		public string LastServiceMileage;
		public DateTime? LastServiceTime;
	}
}
