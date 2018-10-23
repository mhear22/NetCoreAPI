using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Models.Vehicle;
using CoreApp.Repositories;

namespace CoreApp.Services
{
	public interface IVinService
	{
		CarModel GetCar(string Vin);
	}

	public class VinService : ServiceBase, IVinService
	{
		private IManufacturerService manufacturerService;

		public VinService(
			IContext context,
			IManufacturerService manufacturerService
		) : base(context)
		{
			this.manufacturerService = manufacturerService;
		}

		public CarModel GetCar(string Vin)
		{
			var result = new CarModel();

			var manufacturer = this.manufacturerService.GetForVinPrefix(Vin.Substring(0, 3));
			result.Manufacturer = manufacturer;

			return null;
		}
	}
}
