using CoreApp.Models.Repositories;
using CoreApp.Models.Repositories.Vehicle;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Repositories
{
	public class ServiceReminderDto: IRow
	{
		public string Id { get; set; }
		public string Description { get; set; }

		public string ServiceTypeId { get; set; }
		public string RepeatingTypeId { get; set; }
		public string RepeatingFigure { get; set; }
		public string OwnedCarId { get; set; }

		[ForeignKey("OwnedCarId")]
		public OwnedCarDto OwnedCar { get; set; }

		[ForeignKey("RepeatingTypeId")]
		public RepeatTypeDto RepeatingType { get; set; }

		[ForeignKey("ServiceTypeId")]
		public ServiceTypeDto ServiceType { get; set; }

		[ForeignKey("ServiceReminderId")]
		public ICollection<ServiceReceiptDto> Receipts { get; set; }
	}
}
