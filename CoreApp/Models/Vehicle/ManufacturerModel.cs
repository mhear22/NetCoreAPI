using CoreApp.Models.Repositories.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models.Vehicle
{
	public class ManufacturerModel
	{
		public string Name;
		public string VinPrefix;
	}

	public static class ManufacturerExtentions
	{
		public static ManufacturerModel ToModel(this ManufacturerDto dto)
		{
			return new ManufacturerModel()
			{
				Name = dto.Name,
				VinPrefix = dto.VinPrefix
			};
		}
	}
}
