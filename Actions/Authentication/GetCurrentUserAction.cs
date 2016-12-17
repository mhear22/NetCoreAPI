using dotapi.Models.Authentication;
using dotapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions.Authentication
{
	public class GetCurrentUserAction : UserAction
	{
		public GetCurrentUserAction()
		{
			AddAction(() => CurrentUserBySession());
			AddAction(() => GetCurrentUser());
		}
		
		protected IActionResult GetCurrentUser()
		{
			//return S<IAuthenticationService>().Get()
			return BadRequest();
		}
	}
}