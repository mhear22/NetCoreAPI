using CoreApp.Actions.User;
using CoreApp.Models.Authentication;
using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Controllers
{
	public class SessionsController: ApiController
	{
		private IUserAction userAction;
		private IAuthenticationService authenticationService;

		public SessionsController(
			IContext context,
			IUserAction userAction,
			IAuthenticationService authenticationService
		)
			: base(context) 
		{
			this.authenticationService = authenticationService;
			this.userAction = userAction;
		}
		
		[Route("sessions")]
		[HttpPost]
		public IActionResult Login([FromBody]LoginModel model)
		{
			return userAction.LoginAction(model).WithRequest(Request);
		}
		
		[Route("sessions")]
		[HttpDelete]
		public IActionResult Logout(string Id)
		{
			if (!string.IsNullOrWhiteSpace(Id))
				authenticationService.Logout(Id);
			return Ok();
		}
	}
}