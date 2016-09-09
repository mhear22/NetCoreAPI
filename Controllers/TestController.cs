using Microsoft.AspNetCore.Mvc;

namespace dotapi.Controllers
{
	public class TestController : Controller
	{
		[HttpGet]
		[Route("status")]
		public IActionResult Get()
		{
			return new AuthenticationAction().WithRequest(Request);
		}
	} 
}