using CoreApp.Actions.User;
using CoreApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Controllers
{
	public class CurrentUserController: ApiController
	{
		public IUserAction userAction;

		public CurrentUserController(IContext context, IUserAction userAction)
			: base(context)
		{
			this.userAction = userAction;
		}
		
		[Route("currentuser")]
		[HttpGet]
		public IActionResult GetCurrentUser()
		{
			return userAction.GetCurrentUser().WithRequest(Request);
		}
	}
}