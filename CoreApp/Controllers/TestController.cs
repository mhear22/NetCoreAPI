using CoreApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreApp.Controllers
{
	public class TestController : Controller
	{
		private IServiceProvider provider;
		public TestController(IServiceProvider provider)
		{
			this.provider = provider;
		}

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
		
		[HttpGet("services")]
		public IActionResult ServicesAccess()
		{

			IStatusService statusService = null;

			try
			{
				statusService = (IStatusService)provider.GetService(typeof(IStatusService));
			}
			catch (Exception ex) {
				return Ok("Status Service is not building correctly, " + ex.Message);
			}
			return Ok(statusService.GetServiceStatus());
		}
	}
}