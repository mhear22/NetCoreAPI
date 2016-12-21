using dotapi.Models.Authentication;
using dotapi.Actions.User;
using dotapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions.Session
{
	public class LoginAction : UserAction
	{
		public LoginAction(LoginModel model)
		{
			AddAction(() => UserByNameOrId(model.Username));
			AddAction(() => Login(model));
		}
		
		public IActionResult Login(LoginModel model)
		{
			var token = S<IAuthenticationService>().Login(model);
			if(token == null)
				return BadRequest();
			return Ok(token);
		}
	}
}