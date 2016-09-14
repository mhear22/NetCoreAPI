using dotapi.Repositories;

namespace dotapi.Services
{
	interface IAuthenticationService
	{
		
	}
	
    public class AuthenticationService : ServiceBase, IAuthenticationService
    {
		public AuthenticationService(DatabaseContext context)
			: base(context)
		{ }
		
		public string StatusText()
		{
			return "Injected";
		}
    }
}