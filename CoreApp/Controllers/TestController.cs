using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Controllers
{
	public class TestController : Controller
	{
		[HttpGet]
		[Route("status")]
		public IActionResult Get()
		{
			return Ok("Server Up");
		}

		[HttpGet]
		[Route("")]
		public IActionResult RedirectToSwagger()
		{
			return Redirect("/swagger/index.html");
		}
	}
}