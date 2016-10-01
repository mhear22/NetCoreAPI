using dotapi.Models.Authentication;
using dotapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions.Authentication
{
	public class LoginAction : UserAction
	{
		public LoginAction(LoginModel model)
			: base(model.Username)
		{
			AddAction(() => Login(model));
		}
		
		public IActionResult Login(LoginModel model)
		{
			return Ok(S<IAuthenticationService>().Login(model));
		}
	}
}