using CoreApp.Models.Repositories;
using CoreApp.Models.Repositories.Vehicle;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Repositories.Payment
{
	public class PaymentDto: IRow
	{
		public string Id { get; set; }
		public string PaymentPlanId { get; set; }
		public string UserId { get; set; }
		public string OwnedCarId { get; set; }

		public DateTime? CreatedDate { get; set; }

		[ForeignKey("OwnedCarId")]
		public OwnedCarDto OwnedCar { get; set; }

		[ForeignKey("PaymentPlanId")]
		public PaymentPlanDto PaymentPlan { get; set; }

		[ForeignKey("UserId")]
		public UserDto User { get; set; }
	}
}
