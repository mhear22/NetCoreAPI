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
		
		[Route("users/{userIdOrName}")]
		[HttpGet]
		public IActionResult GetUser(string userIdOrName)
		{
			return new GetUserAction(userIdOrName).WithRequest(Request);
		}
	}
}