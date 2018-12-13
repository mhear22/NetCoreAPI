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
		
		[HttpGet]
		[Route("style.css")]
		public IActionResult Styles()
		{
			return new ContentResult()
			{
				Content = @"
				* { 
					background-color:black !important;
					color:white !important;
				}
				",
				StatusCode = 200,
				ContentType = "text/css"
			};
		}
	}
}