using CoreApp.Models.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Repositories
{
	public class ServiceReceiptDto : IRow
	{
		public string Id { get; set; }
		public string ServiceReminderId { get; set; }
		public string CurrentMiles { get; set; }
		public DateTime CreatedDate { get; set; }
		
		[ForeignKey("ServiceReminderId")]
		public ServiceReminderDto ServiceReminder { get; set; }
	}
}
