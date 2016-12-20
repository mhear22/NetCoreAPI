using dotapi.Actions.Authentication;
using dotapi.Models.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Controllers
{
	public class AuthenticationController : Controller
	{
		[Route("users")]
		[HttpPost]
		public IActionResult CreateUser([FromBody]CreateUserModel model)
		{
			return new CreateUserAction(model).WithRequest(Request);
		}
		
		[Route("sessions")]
		[HttpPost]
		public IActionResult Login([FromBody]LoginModel model)
		{
			return new LoginAction(model).WithRequest(Request);
		}
		
		[Route("sessions")]
		[HttpDelete]
		public IActionResult Logout(string Token)
		{
			return new LogoutAction(Token).WithRequest(Request);
		}
		
		[Route("users/{userIdOrName}")]
		[HttpGet]
		public IActionResult GetUser(string userIdOrName)
		{
			return new GetUserAction(userIdOrName).WithRequest(Request);
		}
		
		[Route("currentuser")]
		[HttpGet]
		public IActionResult GetCurrentUser()
		{
			return new GetCurrentUserAction().WithRequest(Request);
		}
		
		[Route("users/{userIdOrName}")]
		[HttpPut]
		public IActionResult UpdateUser(string userIdOrName, [FromBody] UserModel model)
		{
			return new UpdateUserAction(userIdOrName, model).WithRequest(Request);
		}
	}
}