using CoreApp.Models.Authentication;
using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreApp.Controllers
{
	public class UsersController : ApiController
	{
		private IUserService userService;
		private IPaymentService paymentService;
		public UsersController(
			IContext context,
			IUserService userService,
			IPaymentService paymentService
		) : base(context)
		{
			this.paymentService = paymentService;
			this.userService = userService;
		}

		[Route("users")]
		[HttpPost]
		[ProducesResponseType(200, Type = typeof(UserModel))]
		public IActionResult CreateUser([FromBody]CreateUserModel model) => ReturnResult(() => 
		{
			if(Context.Users.Any(x => x.Username == model.Username))
				return BadRequest("Duplicate Username");
			return Ok(userService.CreateUser(model));
		});
		
		[Route("users/{userIdOrName}")]
		[HttpGet]
		[ProducesResponseType(200, Type = typeof(UserModel))]
		public IActionResult GetUser(string userIdOrName) => ReturnResult(() => 
		{
			var result = userService.GetUser(userIdOrName);
			if (result == null)
				return NotFound();
			return Ok(result);
		});
		
		[Route("users/{userIdOrName}")]
		[HttpPut]
		[ProducesResponseType(200, Type = typeof(UserModel))]
		public IActionResult UpdateUser(string userIdOrName, [FromBody] UserModel model)
		{
			var user = userService.GetUser(userIdOrName);
			return Ok(userService.UpdateUser(user.Id, model));
		}

		[Route("users/{userIdOrName}/plan/{planId}")]
		[HttpPut]
		[ProducesResponseType(200)]
		public IActionResult SetPaymentPlan(string userIdOrName, string planId) =>
			ReturnResult(() => this.paymentService.SetPlan(planId, userService.GetUser(userIdOrName).Id));


		
		[Route("user/{userIdOrName}/password")]
		[HttpPost]
		public IActionResult ChangePassword(string userIdOrName,[FromBody]ChangePasswordModel model) => ReturnResult(() =>
		{
			var currentUser = userService.GetFromSession(GetAPIKey());
			if (!userService.CheckPassword(currentUser.Id, model.OldPassword))
				return BadRequest("Old Password is incorrect");
			userService.SetPassword(currentUser.Id, model.NewPassword);
			return Ok();
		});
	}
}