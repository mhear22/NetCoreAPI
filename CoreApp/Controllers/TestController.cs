using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using CoreApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreApp.Controllers
{
	public class TestController : Controller
	{
		private IStatusService statusService;
		private IReminderReportService reminderReportService;

		public TestController(
			IStatusService statusService,
			IReminderReportService reminderReportService
		)
		{
			this.reminderReportService = reminderReportService;
			this.statusService = statusService;
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
			return Ok(statusService.GetServiceStatus());
		}

		[HttpGet("dailyrun")]
		public IActionResult DailyRun()
		{
			this.reminderReportService.BuildEmails();
			return Ok();
		}
	}
}