using Microsoft.AspNetCore.Mvc;

namespace dotapi.Controllers
{
	public class TestController : Controller
	{
		[HttpGet]
		[Route("status")]
		public IActionResult Get()
		{
			return Ok("Server Up");
		}
	}
}