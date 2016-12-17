using dotapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions.Authentication
{
	public class UserAction : ActionBase
	{
		public UserAction() { }
		
		protected IActionResult CurrentUserBySession()
		{
			
			//var user = S<ITokenService>().Get().UserId;
			return null;
		}
		
		protected IActionResult UserByNameOrId(string UserNameOrId)
		{
			var user = S<IAuthenticationService>().Get(UserNameOrId);
			if(user == null)
				return BadRequest("User Doesnt Exist");
			return null;
		}
	}
}