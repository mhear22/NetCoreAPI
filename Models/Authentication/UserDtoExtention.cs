using dotapi.Models.Repositories;

namespace dotapi.Models.Authentication
{
	public static class UserDtoExtention
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