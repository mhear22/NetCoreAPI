using CoreApp.Models.Generic;
using CoreApp.Models.Repositories;
using CoreApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Services
{
	public interface ICountryService
	{
		CountryModel GetForVin(string Vin);
	}

	public class CountryService : ServiceBase, ICountryService
	{
		private IRepository<CountryDto> country;
		public CountryService(
			IContext context,
			IRepository<CountryDto> country
		) : base(context)
		{
			this.country = country;
		}

		public CountryModel GetForVin(string VinPrefix)
		{
			this.country.Where(x => x.VinPrefix == VinPrefix);
			throw new NotImplementedException();
		}
	}
}
