using CoreApp.Actions.User;
using dotapi.Actions.User;
using dotapi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Controllers
{
	public class CurrentUserController: ApiController
	{
		public GetCurrentUserAction userAction;

		public CurrentUserController(IContext context, GetCurrentUserAction userAction)
			: base(context)
		{
			this.userAction = userAction;
		}
		
		[Route("currentuser")]
		[HttpGet]
		public IActionResult GetCurrentUser()
		{
			return userAction.WithRequest(Request);
		}
	}
}