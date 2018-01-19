using CoreApp.Actions.User;
using CoreApp.Models.Authentication;
using Microsoft.AspNetCore.Mvc;
using CoreApp.Repositories;

namespace CoreApp.Controllers
{
	public class UsersController : ApiController
	{
		private IUserAction userAction;
		private IGetUserAction getAction;
		public UsersController(IContext context, IUserAction userAction, IGetUserAction getAction) 
			: base(context)
		{
			this.userAction = userAction;
			this.getAction = getAction;
		}

		[Route("users")]
		[HttpPost]
		public IActionResult CreateUser([FromBody]CreateUserModel model)
		{
			return userAction.CreateUserAction(model).WithRequest(Request);
		}
		
		[Route("users/{userIdOrName}")]
		[HttpGet]
		public IActionResult GetUser(string userIdOrName)
		{
			return getAction.GetUser(userIdOrName).WithRequest(Request);
		}
		
		[Route("users/{userIdOrName}")]
		[HttpPut]
		public IActionResult UpdateUser(string userIdOrName, [FromBody] UserModel model)
		{
			return userAction.UpdateUserAction(userIdOrName, model).WithRequest(Request);
		}
		
		[Route("user/{userIdOrName}/password")]
		[HttpPost]
		public IActionResult ChangePassword(string userIdOrName,[FromBody]ChangePasswordModel model)
		{
			return userAction.ChangePassword(userIdOrName, model).WithRequest(Request);
		}
	}
}