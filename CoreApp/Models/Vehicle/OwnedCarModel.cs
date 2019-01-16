﻿using CoreApp.Models.Repositories.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models.Vehicle
{
	public class OwnedCarModel
	{
		public CarModel Base;
		public string Vin;
		public string Mileage;
		public string Nickname;
		public string EstimatedCurrentMileage;
	}
}
