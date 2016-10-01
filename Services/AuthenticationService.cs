using dotapi.Repositories;
using dotapi.Models.Authentication;
using System;
using dotapi.Models.Repositories;
using System.Linq;

namespace dotapi.Services
{
	interface IAuthenticationService
	{
		UserModel Get(string UserIdOrName);
		UserModel Login(LoginModel model);
		UserModel CreateUser(CreateUserModel model);
	}
	
    public class AuthenticationService : ServiceBase, IAuthenticationService
    {
		private IPasswordService _passwordService;
		public AuthenticationService(DatabaseContext context, IPasswordService passwordService)
			: base(context)
		{
			_passwordService = passwordService;
		}
		
		private UserDto GetDTO(string UserIdOrName)
		{
			return Context.Users
				.FirstOrDefault(x=>
					x.Id == UserIdOrName || 
					x.Username == UserIdOrName || 
					x.EmailAddress == UserIdOrName);
		}
		public UserModel Get(string UserIdOrName)
		{
			return GetDTO(UserIdOrName).ToModel();
		}
        public UserModel CreateUser(CreateUserModel model)
        {
			var userDto = new UserDto()
			{
				Username = model.Username,
				EmailAddress = model.Email,
				Id = Guid.NewGuid().ToString()
			};
			Context.Users.Add(userDto);
			Context.SaveChanges();
			_passwordService.SetPassword(userDto.Id, model.Password);
			
			return Get(userDto.Id);
        }

        public UserModel Login(LoginModel model)
        {
			var user = GetDTO(model.Username);
			if(_passwordService.CheckPassword(user.Id, model.Password))
				return user.ToModel();
			return null;
        }
    }
}