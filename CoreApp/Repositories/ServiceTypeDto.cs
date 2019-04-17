using CoreApp.Models.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Repositories
{
	public class ServiceTypeDto : IRow
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public bool Premium { get; set; }
		//Maybe have image for the service item, or most common change freq
		
		public string UserId { get; set; }

		[ForeignKey("UserId")]
		public UserDto User { get; set; }

		[ForeignKey("ServiceTypeId")]
		public ICollection<ServiceReminderDto> Reminders;
		

		public static string Brakes = "brakes";
		public static string OilChange = "oilchange";
		public static string CoolantFlush = "coolant";
		public static string TimingEquipment = "timing";
		public static string Registration = "rego";
		public static string GeneralService = "generalservice";
	}
}
