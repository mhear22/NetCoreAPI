using System;
using System.Collections.Generic;
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
