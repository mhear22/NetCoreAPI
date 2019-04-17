using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models.Repositories.Vehicle
{
	public class MileageRecordingDto : IRow
	{
		public string Id { get; set; }
		public string OwnedCarId { get; set; }
		public DateTime RecordingDate { get; set; }
		public string Mileage { get; set; }

		[ForeignKey("OwnedCarId")]
		public OwnedCarDto OwnedCar { get; set; }
	}
}
