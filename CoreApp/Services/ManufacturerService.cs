using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Models.Repositories.Vehicle;
using CoreApp.Models.Vehicle;
using CoreApp.Repositories;

namespace CoreApp.Services
{
	public interface IManufacturerService
	{
		ManufacturerModel GetForId(string ManufacturerId);
		ManufacturerModel GetForVinPrefix(string Vin);
	}

	public class ManufacturerService : ServiceBase, IManufacturerService
	{
		private IRepository<ManufacturerDto> manufacturers;
		public ManufacturerService(
			IContext context,
			IRepository<ManufacturerDto> manufacturers
		)
			: base(context)
		{
			this.manufacturers = manufacturers;
		}

		public ManufacturerModel GetForId(string ManufacturerId)
		{
			return this.manufacturers.Get(ManufacturerId).ToModel();
		}

		public ManufacturerModel GetForVinPrefix(string VinPrefix)
		{
			return this.manufacturers.Where(x => x.VinPrefix == VinPrefix).FirstOrDefault().ToModel();
		}
	}
}
