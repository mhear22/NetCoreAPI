using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models.Repositories.Vehicle
{
	public class CarDto: IRow
	{
		public string Id { get; set; }
		public string ManufacturerId { get; set; }
		
		[ForeignKey("ManufacturerId")]
		public ManufacturerDto Manufacturer { get; set; }
	}
}
