using CoreApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models.Repositories.Vehicle
{
	public class OwnedCarDto: IRow
	{
		public string Id { get; set; }
		public string Nickname { get; set; }
		
		public string CarId { get; set; }
		public string Vin { get; set; }
		public string UserId { get; set; }
		public DateTime ManufacturedDate { get; set; }

		[ForeignKey("CarId")]
		public CarDto BaseModel { get; set; }

		[ForeignKey("UserId")]
		public UserDto Owner { get; set; }

		[ForeignKey("OwnedCarId")]
		public ICollection<MileageRecordingDto> MileageRecordings { get; set; }

		[ForeignKey("OwnedCarId")]
		public ICollection<ServiceReminderDto> ServiceReminders { get; set; }
	}
}
