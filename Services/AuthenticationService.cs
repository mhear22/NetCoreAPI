using System;
using dotapi.Models.Authentication;
using dotapi.Models.Repositories;
using dotapi.Repositories;

namespace dotapi.Services
{
	interface IAuthenticationService
	{
		void Login(LoginModel model);
		string StatusText();
	}
	
    public class AuthenticationService : ServiceBase, IAuthenticationService
    {
		private static RepoBase<UserDto> userRepo = new RepoBase<UserDto>();
		
        public void Login(LoginModel model)
        {
            throw new NotImplementedException();
        }
		
		public string StatusText()
		{
			userRepo.Get("");
			return "Injected";
		}
    }
}