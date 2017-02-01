using dotapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions.User
{
	public interface IGetUserAction
	{
		GetUserAction GetUser(string userIdOrName);
	}
	
	public class GetUserAction : ActionBase, IGetUserAction
	{
		private IAuthenticationService authService;
		public GetUserAction(IAuthenticationService auth)
		{
			authService = auth;
		}
		
		public GetUserAction GetUser(string userIdOrName)
		{
			AddAction(() => {
				var user = authService.Get(userIdOrName);
				if(user == null)
					return NotFound();
				return Ok(user);
			});
			return this;
		}
	}
}