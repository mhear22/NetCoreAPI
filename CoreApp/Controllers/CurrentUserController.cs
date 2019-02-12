using CoreApp.Models.Authentication;
using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Controllers
{
	public class CurrentUserController: ApiController
	{
		private ICurrentUserService currentUserService;
		public CurrentUserController(
			IContext context,
			ICurrentUserService currentUserService
		) : base(context)
		{
			this.currentUserService = currentUserService;
		}
		
		[Route("currentuser")]
		[HttpGet]
		[ProducesResponseType(200, Type = typeof(UserModel))]
		public IActionResult GetCurrentUser() => 
			ReturnResult(() => this.currentUserService.CurrentUser());
	}
}