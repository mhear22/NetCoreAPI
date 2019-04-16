using CoreApp.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Repositories
{
	public class RepeatTypeDto : IRow
	{
		public string Id { get; set; }
		public string Name { get; set; }

		public static string Age = "age";
		public static string Mileage = "mileage";
	}
}
