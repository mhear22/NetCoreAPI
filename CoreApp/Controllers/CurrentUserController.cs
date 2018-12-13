using CoreApp.Models.Authentication;
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
		[ProducesResponseType(200, Type = typeof(UserModel))]
		public IActionResult GetCurrentUser() => ReturnResult(() => this.userService.GetFromSession(GetAPIKey()));
	}
}