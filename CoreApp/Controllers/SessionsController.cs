using System;
using CoreApp.Models.Authentication;
using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Controllers
{
	public class SessionsController: ApiController
	{
		private IAuthenticationService authenticationService;

		public SessionsController(
			IContext context,
			IAuthenticationService authenticationService
		)
			: base(context) 
		{
			this.authenticationService = authenticationService;
		}
		
		[Route("sessions")]
		[HttpPost]
		[ProducesResponseType(200, Type = typeof(string))]
		public IActionResult Login([FromBody]LoginModel model) => ReturnResult(() =>
		{
			var key = authenticationService.Login(model);
			if (string.IsNullOrWhiteSpace(key))
				throw new ArgumentException("Login Failed");
			return key;
		});
		
		[Route("sessions")]
		[HttpDelete]
		public IActionResult Logout(string Token)
		{
			if (!string.IsNullOrWhiteSpace(Token))
				authenticationService.Logout(Token);
			return Ok();
		}
	}
}