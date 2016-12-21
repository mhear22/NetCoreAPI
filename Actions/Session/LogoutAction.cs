using dotapi.Models.Authentication;
using dotapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions.Session
{
	public class LogoutAction : ActionBase
	{
		public LogoutAction(string Id)
		{
			AddAction(() => Logout(Id));
		}
		
		public IActionResult Logout(string Id)
		{
			var token = S<IAuthenticationService>().Logout(Id);
			return Ok();
		}
	}
}