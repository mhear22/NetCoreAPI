using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Controllers
{
	public class EmailController : ApiController
	{
		private IEmailService emailService;
		public EmailController(
			IContext context,
			IEmailService emailService
			) : base(context)
		{
			this.emailService = emailService;
		}

		[Route("email/{Vin}")]
		[HttpPost]
		[ProducesResponseType(200)]
		public IActionResult SendTestEmail(string Vin) =>
			ReturnResult(() => this.emailService.SendTestEmail(Vin));
	}
}
