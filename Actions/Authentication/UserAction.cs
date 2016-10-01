using dotapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions.Authentication
{
	public class UserAction : ActionBase
	{
		public UserAction(string userIdOrName)
		{
			AddAction(() => CheckValidUser(userIdOrName));
		}
		public IActionResult CheckValidUser(string username)
		{
			var user = S<IAuthenticationService>().Get(username);
			if(user == null)
				return BadRequest("User Doesnt Exist");
			return null;
		}
	}
}