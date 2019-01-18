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
		private IMileageService mileageService;
		public CarReport(
			IContext Context,
			IMileageService mileageService
		) :base(Context)
		{
			this.mileageService = mileageService;
		}

		protected override object Execute() 
		{
			var vin = this.Get("vin");
			var car = Context.OwnedCars
				.Include(x=>x.ServiceReminders)
				.Include(x=>x.MileageRecordings)
				.FirstOrDefault(z=>z.Vin == vin);

			var serviceReminders = Context.ServiceReminders
					.Where(x => x.OwnedCarId == car.Id)
					.Include(x => x.Receipts)
					.Include(x => x.ServiceType)
					.ToList();

			var mileage = mileageService.GetGraphMileage(vin);
			var estimatedMileage = mileageService.EstimateCurrent(vin);
			var seperation = 100d/(double)mileage.Count();


			return new {
				domain = "http://localhost:4200",
				seperation,
				Car = car,
				Vin = car.Vin,
				ServiceReminders = serviceReminders,
				mileage = mileage.Select(x => {
					return new
					{
						x.Recording,
						x.Year,
						Percentage = double.Parse(x.Recording) / double.Parse(mileage.Last().Recording) * 100
					};
				}).ToList(),
				estimatedMileage
			};
		}
	}
}
