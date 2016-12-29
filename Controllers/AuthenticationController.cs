using dotapi.Actions.User;
using dotapi.Actions.Session;
using dotapi.Models.Authentication;
using Microsoft.AspNetCore.Mvc;
using dotapi.Repositories;

namespace dotapi.Controllers
{
	public class AuthenticationController : ApiController
	{
		private IUserAction userAction;
		private IGetUserAction getAction;
		private ILogoutAction logout;
		public AuthenticationController(IContext context, IUserAction userAction, IGetUserAction getAction, ILogoutAction logout) 
			: base(context)
		{
			this.userAction = userAction;
			this.getAction = getAction;
			this.logout = logout;
		}

		[Route("users")]
		[HttpPost]
		public IActionResult CreateUser([FromBody]CreateUserModel model)
		{
			return userAction.CreateUserAction(model).WithRequest(Request);
		}
		
		[Route("sessions")]
		[HttpPost]
		public IActionResult Login([FromBody]LoginModel model)
		{
			return this.userAction.LoginAction(model).WithRequest(Request);
		}
		
		[Route("sessions")]
		[HttpDelete]
		public IActionResult Logout(string Token)
		{
			return logout.Logout(Token).WithRequest(Request);
		}
		
		[Route("users/{userIdOrName}")]
		[HttpGet]
		public IActionResult GetUser(string userIdOrName)
		{
			return getAction.GetUser(userIdOrName).WithRequest(Request);
		}
		
		[Route("currentuser")]
		[HttpGet]
		public IActionResult GetCurrentUser()
		{
			return userAction.GetCurrentUserAction().WithRequest(Request);
		}
		
		[Route("users/{userIdOrName}")]
		[HttpPut]
		public IActionResult UpdateUser(string userIdOrName, [FromBody] UserModel model)
		{
			return userAction.UpdateUserAction(userIdOrName, model).WithRequest(Request);
		}
	}
}