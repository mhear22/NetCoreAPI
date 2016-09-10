using dotapi.Repositories.Attributes;

namespace dotapi.Models.Repositories
{
    public class UserDto : IRow
    {
		[Table("Users")]
		public string Id { get; set; }
		[Column("username")]
		public string username;
    }
}