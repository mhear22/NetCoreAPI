using CoreApp.Repositories;
using CoreApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Forms.CarService
{
	public class CarReport: ReportBase
	{
		private ICarService carService;
		public CarReport(
			IContext Context,
			ICarService carService
		) :base(Context)
		{
			this.carService = carService;
		}

		protected override object Execute() 
		{
			var vin = this.Get("vin");
			var car = this.carService.Get(vin);
			
			
			return new {
				Car = car,
				Vin = car.Vin
			};
		}
	}
}
