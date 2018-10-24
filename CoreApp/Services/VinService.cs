using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Models.Repositories.Vehicle;
using CoreApp.Models.Vehicle;
using CoreApp.Repositories;
using Microsoft.EntityFrameworkCore;
using CoreApp.Models.Generic;

namespace CoreApp.Services
{
	public interface IVinService
	{
		CarModel GetCar(string Vin);
	}

	public class VinService : ServiceBase, IVinService
	{
		private IManufacturerService manufacturerService;
		private ICountryService countryService;
		private IRepository<VinVIS> VinVIS;
		private IRepository<VinWMI> VinWMI;
		private IRepository<VinVDS> VinVDS;

		public VinService(
			IContext context,
			IManufacturerService manufacturerService,
			ICountryService countryService,
			IRepository<VinVIS> VinVIS,
			IRepository<VinWMI> VinWMI,
			IRepository<VinVDS> VinVDS
		) : base(context)
		{
			this.VinVIS = VinVIS;
			this.VinWMI = VinWMI;
			this.VinVDS = VinVDS;
			this.countryService = countryService;
			this.manufacturerService = manufacturerService;
		}

		public CarModel GetCar(string Vin)
		{
			if(Vin.Length == 17)
			{
				var result = new CarModel();
				var WMI = Vin.Substring(0, 3);
				var VDS = Vin.Substring(3, 6);
				var VIS = Vin.Substring(9, 8);

				var Vins = this.VinWMI.Where(x => Vin.StartsWith(x.Matcher));
			
				var WMIData = Vins
					.Include(x=>x.Manufacturer)
					.Include(x=>x.Country)
					.FirstOrDefault();

				return new CarModel()
				{
					Manufacturer = WMIData?.Manufacturer?.ToModel(),
					ManufacturerId = WMIData?.ManufacturerId,
					CountryOfOrigin = WMIData?.Country?.ToModel(),
					CountryId = WMIData?.CountryId,
					Vin = Vin
				};
			} 
			else
			{
				return null;
			}
		}
	}
}
