using dotapi.Models.Authentication;
using dotapi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace dotapi.Actions.User
{
	public class UserAction : ActionBase
	{
		public UserAction()
		{
			AddAction(() => CurrentUserBySession());
		}
		
		protected UserModel User;
		protected UserModel CurrentUser;
		private IActionResult CurrentUserBySession()
		{
			var x = GetKey("api_key");
			if(string.IsNullOrWhiteSpace(x))
				return BadRequest("No Logged in user");
			var UserId = S<ITokenService>().Get(x).UserId;
			CurrentUser = S<IAuthenticationService>().Get(UserId);
			return null;
		}
		
		protected IActionResult UserByNameOrId(string UserNameOrId)
		{
			var user = S<IAuthenticationService>().Get(UserNameOrId);
			if(user == null)
				return BadRequest("User Doesnt Exist");
			User = user;
			return null;
		}
	}
}