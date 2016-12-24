using dotapi.Models.Authentication;
using dotapi.Actions.User;
using dotapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions.CurrentUser
{
	public class GetCurrentUserAction : UserAction
	{
		public GetCurrentUserAction()
		{
			AddAction(() => GetCurrentUser());
		}
		
		protected IActionResult GetCurrentUser()
		{
			return Ok(CurrentUser);
		}
	}
}