using CoreApp.Actions.Session;
using CoreApp.Actions.User;
using CoreApp.Models.Authentication;
using CoreApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Controllers
{
	public class SessionsController: ApiController
	{
		private IUserAction userAction;
		private ILogoutAction logout;
		public SessionsController(IContext context, IUserAction userAction, ILogoutAction logout)
			: base(context) 
		{
			this.userAction = userAction;
			this.logout = logout;
		}
		
		[Route("sessions")]
		[HttpPost]
		public IActionResult Login([FromBody]LoginModel model)
		{
			return userAction.LoginAction(model).WithRequest(Request);
		}
		
		[Route("sessions")]
		[HttpDelete]
		public IActionResult Logout(string Token)
		{
			return logout.Logout(Token).WithRequest(Request);
		}
	}
}