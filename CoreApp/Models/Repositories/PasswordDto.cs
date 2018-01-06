using System;

namespace CoreApp.Models.Repositories
{
	public class PasswordDto : IRow
	{
		public string Id { get; set; }
		public string UserId { get; set; }
		public string Hash { get; set; }
		public DateTime DateSet { get; set; } 
	}
}