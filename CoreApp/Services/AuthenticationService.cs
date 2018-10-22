using CoreApp.Repositories;
using CoreApp.Models.Authentication;
using System;
using CoreApp.Models.Repositories;
using System.Linq;
using System.Collections.Generic;

namespace CoreApp.Services
{
	public interface IAuthenticationService
	{
		UserModel Get(string UserIdOrName);
		List<UserModel> GetDuplicates(UserModel model);
		string Logout(string Id);
		string Login(LoginModel model);
		UserModel CreateUser(CreateUserModel model);
		UserModel UpdateUser(string Id,UserModel model);
	}
	
	public class AuthenticationService : ServiceBase, IAuthenticationService
	{
		private IPasswordService _passwordService;
		private ITokenService _tokenService;
		private IRepository<UserDto> _userRepo;
		public AuthenticationService(IContext context, IPasswordService passwordService, ITokenService tokenService, IRepository<UserDto> userRepo)
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
		
		public List<UserModel> GetDuplicates(UserModel model)
		{
			return _userRepo.Where(x=>
				x.EmailAddress == model.EmailAddress ||
				x.Username == model.Username)
				.ToList()
				.Select(x=>x.ToModel())
				.ToList();
		}
		
		public UserModel CreateUser(CreateUserModel model)
		{
			var userDto = new UserDto()
			{
				Username = model.Username,
				EmailAddress = model.EmailAddress,
				Id = Guid.NewGuid().ToString()
			};
			
			_userRepo.Create(userDto);
			_passwordService.SetPassword(userDto.Id, model.Password);
			return Get(userDto.Id);
		}
		
		public string Login(LoginModel model)
		{
			var user = GetDto(model.Username);
            if(user == null) { return null; }
			if(_passwordService.CheckPassword(user.Id, model.Password))
				return _tokenService.Create(user.Id);
			return null;
		}

		public string Logout(string Id)
		{
			return _tokenService.Delete(Id);
		}

		public UserModel UpdateUser(string Id, UserModel model)
		{
			return _userRepo.Update(Id, model.ToDTO()).ToModel();
		}
	}
}