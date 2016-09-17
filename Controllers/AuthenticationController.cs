using dotapi.Actions.Authentication;
using dotapi.Models.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Controllers
{
	public class AuthenticationController : Controller
	{
		[Route("users")]
		[HttpPost]
		public IActionResult CreateUser(CreateUserModel model)
		{
			return new CreateUserAction(model).WithRequest(Request);
		}
		
		[Route("sessions")]
		[HttpPost]
		public IActionResult Login(LoginModel model)
		{
			return Ok();
		}
	}
}