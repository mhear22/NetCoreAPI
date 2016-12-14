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
		string Logout(string Id);
		string Login(LoginModel model);
		UserModel CreateUser(CreateUserModel model);
	}
	
	public class AuthenticationService : ServiceBase, IAuthenticationService
	{
		private IPasswordService _passwordService;
		private ITokenService _tokenService;
		private IRepository<UserDto> _userRepo;
		public AuthenticationService(DatabaseContext context, IPasswordService passwordService, ITokenService tokenService, IRepository<UserDto> userRepo)
			: base(context)
		{
			_userRepo = userRepo;
			_passwordService = passwordService;
			_tokenService = tokenService;
		}
		
		private UserDto GetDto(string UserIdOrName)
		{
			return _userRepo.Where(x=> 
					x.Id == UserIdOrName || 
					x.Username == UserIdOrName || 
					x.EmailAddress == UserIdOrName)
				.FirstOrDefault();
		}
		
		public UserModel Get(string UserIdOrName)
		{
			return GetDto(UserIdOrName).ToModel();
		}
		
		public UserModel CreateUser(CreateUserModel model)
		{
			var userDto = new UserDto()
			{
				Username = model.Username,
				EmailAddress = model.Email,
				Id = Guid.NewGuid().ToString()
			};
			
			_userRepo.Create(userDto);
			_passwordService.SetPassword(userDto.Id, model.Password);
			return Get(userDto.Id);
		}
		
		public string Login(LoginModel model)
		{
			var user = GetDto(model.Username);
			if(_passwordService.CheckPassword(user.Id, model.Password))
				return _tokenService.Create(user.Id);
			return null;
		}

        public string Logout(string Id)
        {
			return _tokenService.Delete(Id);
        }
    }
}