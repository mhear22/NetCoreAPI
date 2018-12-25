using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Models.Repositories.Vehicle;
using CoreApp.Models.Vehicle;
using CoreApp.Repositories;

namespace CoreApp.Services
{
	public interface IMileageService
	{
		void UpdateMileage(MileageModel model);
		List<MileageRecordingModel> GetMileage(string Vin);
	}

	public class MileageService : ServiceBase, IMileageService
	{
		private ICurrentUserService currentUserService;
		public MileageService(
			IContext context,
			ICurrentUserService currentUserService
		) : base(context)
		{
			this.currentUserService = currentUserService;
		}
		
		public void UpdateMileage(MileageModel model)
		{
			var currentUser = this.currentUserService.CurrentUser();
			var OwnedCar = Context.OwnedCars.FirstOrDefault(x => x.Vin == model.Vin);

			if (OwnedCar.UserId != currentUser.Id)
				throw new UnauthorizedAccessException();

			if (OwnedCar == null)
				throw new ArgumentException("This Vin has not been added");

			var Mileage = float.Parse(model.Mileage);
			var LastMileage = Context.MileageRecordings
				.Where(x=>x.OwnedCarId == OwnedCar.Id)
				.OrderByDescending(x => x.RecordingDate)?
					.FirstOrDefault()?.Mileage??"0";

			if (float.Parse(LastMileage) > Mileage)
				throw new ArgumentException("Mileage is too low");

			var dto = new MileageRecordingDto()
			{
				Mileage = model.Mileage,
				OwnedCarId = OwnedCar.Id,
				RecordingDate = DateTime.UtcNow,
			};

			Context.MileageRecordings.Add(dto);
			Context.SaveChanges();
		}
	
		public List<MileageRecordingModel> GetMileage(string Vin) {
			var carIds = Context.OwnedCars
				.Where(x=>x.Vin == Vin)
				.Select(x=>x.Id)
				.ToList();
			var mileage = Context.MileageRecordings
				.Where(x=>carIds.Contains(x.OwnedCarId))
				.GroupBy(x=>x.RecordingDate.Year)
				.Select(x=>x.OrderByDescending(z=>z.Mileage).FirstOrDefault())
				.Select(x=>new MileageRecordingModel(){
					Recording = x.Mileage,
					Year = x.RecordingDate.Year
				}).ToList();
			var start = mileage.OrderBy(x=>x.Year).FirstOrDefault().Year;
			var end = DateTime.Now.Year;
			return Enumerable.Range(0, end - start + 1).Select(x=>{ 
				var recording = 0;
				var year = start + x;
				
				var mileRecording = mileage.FirstOrDefault(z=>z.Year == year);
				if(mileRecording != null)
					recording = int.Parse(mileRecording.Recording);
				
				return new MileageRecordingModel() {
					Year =  year,
					Recording = recording.ToString()
				};
			}).ToList();
		}
	}
	
	public class MileageRecordingModel {
		public int Year;
		public string Recording;
	}
}
