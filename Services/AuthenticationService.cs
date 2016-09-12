using System;
using dotapi.Models.Authentication;
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
		public AuthenticationService(DatabaseContext context)
			: base(context)
		{
			
		}
		
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