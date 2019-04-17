using CoreApp.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models.Generic
{
	public class CountryModel
	{
		public string Name;
		public string VinPrefix;
	}

	public static class CountryExtentions
	{
		public static CountryModel ToModel(this CountryDto dto)
		{
			return new CountryModel()
			{
				Name = dto.Name,
				VinPrefix = dto.VinPrefix
			};
		}
	}
}
