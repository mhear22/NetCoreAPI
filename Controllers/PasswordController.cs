using dotapi.Actions.User;
using dotapi.Actions.Session;
using dotapi.Actions.CurrentUser;
using dotapi.Models.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Controllers
{
	public class PasswordController : Controller
	{
		[Route("user/{userIdOrName}/password")]
		[HttpPost]
		public IActionResult ChangePassword(string userIdOrName,[FromBody]ChangePasswordModel model)
		{
			return new ChangePasswordAction(userIdOrName, model).WithRequest(Request);
		}
	}
}