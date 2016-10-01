using dotapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions.Authentication
{
	public class GetUserAction : ActionBase
	{
		public GetUserAction(string userIdOrName)
		{
			AddAction(() => GetUser(userIdOrName));
		}
		public IActionResult GetUser(string userIdOrName)
		{
			return Ok(S<IAuthenticationService>().Get(userIdOrName));
		}
	}
	
}