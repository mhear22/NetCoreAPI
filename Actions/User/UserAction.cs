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
				return null;
			var userFromToken = S<ITokenService>().Get(x);
			if(userFromToken == null)
				return null;
			CurrentUser = S<IAuthenticationService>().Get(userFromToken.UserId);
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