namespace dotapi.Models.Repositories
{
	public class UserDto : IRow
	{
		public string Id { get; set;}
		public string Username { get; set; }
		public string EmailAddress { get; set; }
		public string ImageId { get; set; }
	}
}