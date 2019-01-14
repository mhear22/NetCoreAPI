using CoreApp.Repositories.Payment;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreApp.Models.Repositories
{
	public class UserDto : IRow
	{
		public string Id { get; set;}
		public string Username { get; set; }
		public string EmailAddress { get; set; }
		public string ImageId { get; set; }
		public string PaymentPlanId { get; set; }

		[ForeignKey("PaymentPlanId")]
		public PaymentPlanDto PaymentPlan { get; set; }

		[ForeignKey("UserId")]
		public ICollection<PaymentDto> Payments { get; set; }
	}
}