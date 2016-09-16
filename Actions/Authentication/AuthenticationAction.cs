using dotapi.Actions;
using dotapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions.Authentication
{
	public class AuthenticationAction : ActionBase
	{
		internal IAuthenticationService _authService;
		public AuthenticationAction()
		{
			AddAction(() => SetUp());
		}
		
		public IActionResult SetUp()
		{
			_authService = S<IAuthenticationService>();
			return null;
		}
	}
	
}