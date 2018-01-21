using CoreApp.Models.Authentication;
using CoreApp.Models.Repositories;
using CoreApp.Repositories;
using System;

namespace CoreApp.Services
{
	public interface IUserService
	{
		UserModel GetUser(string userIdOrName);
		UserModel GetFromSession(string ApiKey);
		bool CheckPassword(string UserId, string password);
		void SetPassword(string userId, string password);
		UserModel UpdateUser(string Id, UserModel model);
		UserModel CreateUser(CreateUserModel model);
	}
	public class UserService : ServiceBase, IUserService
	{
		private ITokenService tokenService;
		private IAuthenticationService authService;
		private IPasswordService passwordService;
		private IRepository<UserDto> userRepository;
		public UserService(
			IContext context,
			ITokenService tokenService,
			IPasswordService passwordService,
			IAuthenticationService authenticationService,
			IRepository<UserDto> userRepository) 
			: base(context)
		{
			this.tokenService = tokenService;
			this.authService = authenticationService;
			this.passwordService = passwordService;
			this.userRepository = userRepository;
		}
		public UserModel GetUser(string userIdOrName)
		{
			return authService.Get(userIdOrName);
		}
		
		public bool CheckPassword(string UserId, string password)
		{
			return passwordService.CheckPassword(UserId, password);
		}
		
		public void SetPassword(string userId, string password)
		{
			passwordService.SetPassword(userId, password);
		}

		public UserModel GetFromSession(string ApiKey)
		{
			var userFromToken = tokenService.Get(ApiKey);
			if(userFromToken == null)
				return null;
			return authService.Get(userFromToken.UserId);
		}

		public UserModel UpdateUser(string Id, UserModel model)
		{
			return userRepository.Update(Id, model.ToDTO()).ToModel();
		}

		public UserModel CreateUser(CreateUserModel model)
		{
			var userDto = new UserDto()
			{
				Username = model.Username,
				EmailAddress = model.EmailAddress,
				Id = Guid.NewGuid().ToString()
			};

			userRepository.Create(userDto);
			passwordService.SetPassword(userDto.Id, model.Password);
			return GetUser(userDto.Id);
		}
	}
}