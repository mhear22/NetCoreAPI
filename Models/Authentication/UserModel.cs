using dotapi.Models.Repositories;

namespace dotapi.Models.Authentication
{
	public class UserModel
	{
		public string Username;
		public string Email;
	}
	
	public static class UserModelExtentions
	{
		public static UserModel ToModel(this UserDto dto)
		{
			if(dto == null) { return null; }
			return new UserModel()
			{
				Username = dto.Username,
				Email = dto.EmailAddress
			};
		}
	}
	
}