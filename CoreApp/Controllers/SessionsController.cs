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
		public IActionResult Login([FromBody]LoginModel model)
		{
			var key = authenticationService.Login(model);
			if (string.IsNullOrWhiteSpace(key))
				return BadRequest("Login Failed");
			return Ok(key);
		}
		
		[Route("sessions")]
		[HttpDelete]
		public IActionResult Logout(string Id)
		{
			if (!string.IsNullOrWhiteSpace(Id))
				authenticationService.Logout(Id);
			return Ok();
		}
	}
}