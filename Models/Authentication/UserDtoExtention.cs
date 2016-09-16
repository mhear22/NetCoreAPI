using dotapi.Models.Repositories;

namespace dotapi.Models.Authentication
{
	public static class UserDtoExtention
	{
		public static UserModel ToModel(this UserDto dto)
		{
			return new UserModel()
			{
				Username = dto.Username,
				Email = dto.EmailAddress
			};
		}
	}
}