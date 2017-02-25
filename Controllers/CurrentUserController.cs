using dotapi.Actions.User;
using dotapi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Controllers
{
	public class CurrentUserController: ApiController
	{
		private IUserAction userAction;
		public CurrentUserController(IContext context, IUserAction userAction)
			: base(context)
		{
			this.userAction = userAction;
		}
		
		[Route("currentuser")]
		[HttpGet]
		public IActionResult GetCurrentUser()
		{
			return userAction.GetCurrentUserAction().WithRequest(Request);
		}
	}
}