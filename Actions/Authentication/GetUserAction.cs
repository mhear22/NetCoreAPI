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
			var user = S<IAuthenticationService>().Get(userIdOrName);
			if(user == null)
				return BadRequest();
			return Ok(user);
		}
	}
	
}