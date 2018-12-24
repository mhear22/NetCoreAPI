using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models.Repositories.Vehicle
{
	public class ManufacturerDto : IRow
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string VinPrefix { get; set; }
	}
}
