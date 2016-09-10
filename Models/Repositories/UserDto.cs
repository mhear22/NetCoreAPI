using dotapi.Repositories.Attributes;

namespace dotapi.Models.Repositories
{
	[Table("Users")]
    public class UserDto : IRow
    {
		[Column("Id", true)]
		public string Id { get; set; }
		[Column("username")]
		public string username;
    }
}