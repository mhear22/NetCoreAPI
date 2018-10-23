using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models.Repositories.Vehicle
{
	/// <summary>
	/// Vehicle Identification Number World Manufacturer Identifier
	/// </summary>
	public class VinWMI : IRow
	{
		public string Id { get; set; }
		public string Matcher { get; set; }

		public string CountryId { get; set; }
		public string ManufacturerId { get; set; }

		[ForeignKey("ManufacturerId")]
		public ManufacturerDto Manufacturer { get; set; }

		[ForeignKey("CountryId")]
		public CountryDto Country { get; set; }
	}

	/// <summary>
	/// Vehicle Identification Number Vehicle Descriptor Section
	/// </summary>
	public class VinVDS : IRow
	{
		public string Id { get; set; }
		public string Matcher { get; set; }
	}

	/// <summary>
	/// Vehicle Identification Number Vehicle Identifier Section
	/// </summary>
	public class VinVIS : IRow
	{
		public string Id { get; set; }
		public string Matcher { get; set; }
	}
}
