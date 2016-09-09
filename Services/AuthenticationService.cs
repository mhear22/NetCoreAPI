using System;
using dotapi.Models.Authentication;

namespace dotapi.Services
{
	interface IAuthenticationService
	{
		void Login(LoginModel model);
		string StatusText();
	}
	
    public class AuthenticationService : ServiceBase, IAuthenticationService
    {
        public void Login(LoginModel model)
        {
            throw new NotImplementedException();
        }
		
		public string StatusText()
		{
			return "Injected";
		}
    }
}