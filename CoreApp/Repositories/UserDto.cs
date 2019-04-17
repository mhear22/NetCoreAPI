using CoreApp.Repositories;
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
		public string StripeId { get; set; }
		public bool EmailVerified { get; set; }

		[ForeignKey("UserId")]
		public ICollection<SessionDto> sessions { get; set; }

		[ForeignKey("UserId")]
		public ICollection<ServiceTypeDto> CustomTypes { get; set; }
	}
}