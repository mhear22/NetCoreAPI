using dotapi.Actions.User;
using dotapi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Controllers
{
	public class CurrentUserController: ApiController
	{
		public UserAction userAction;

		public CurrentUserController(IContext context, UserAction userAction)
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