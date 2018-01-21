using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Controllers
{
	public class CurrentUserController: ApiController
	{
		private IUserService userService;
		public CurrentUserController(IContext context, IUserService userService)
			: base(context)
		{
			this.userService = userService;
		}
		
		[Route("currentuser")]
		[HttpGet]
		public IActionResult GetCurrentUser()
		{
			return Ok(userService.GetFromSession(GetAPIKey()));
		}
	}
}