using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Forms.CarService
{
	public class CarReport: ReportBase
	{
		public CarReport(
			IContext Context
		) :base(Context)
		{

		}

		protected override object Execute() 
		{
			var vin = this.Get("vin");
			var car = Context.OwnedCars
				.Include(x=>x.ServiceReminders)
				.Include(x=>x.MileageRecordings)
				.FirstOrDefault(z=>z.Vin == vin);
			
			
			return new {
				Car = car,
				Vin = car.Vin
			};
		}
	}
}
