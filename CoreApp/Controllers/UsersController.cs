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
		public UsersController(IContext context,IUserService userService) 
			: base(context)
		{
			this.userService = userService;
		}

		[Route("users")]
		[HttpPost]
		public IActionResult CreateUser([FromBody]CreateUserModel model)
		{
            if(Context.users.Any(x => x.Username == model.Username))
                return BadRequest("Duplicate Username");
			return Ok(userService.CreateUser(model));
		}
		
		[Route("users/{userIdOrName}")]
		[HttpGet]
		public IActionResult GetUser(string userIdOrName)
		{
            var result = userService.GetUser(userIdOrName);
            if (result == null)
                return NotFound();
            return Ok(result);
		}
		
		[Route("users/{userIdOrName}")]
		[HttpPut]
		public IActionResult UpdateUser(string userIdOrName, [FromBody] UserModel model)
		{
			var user = userService.GetUser(userIdOrName);
			return Ok(userService.UpdateUser(user.Id, model));
		}
		
		[Route("user/{userIdOrName}/password")]
		[HttpPost]
		public IActionResult ChangePassword(string userIdOrName,[FromBody]ChangePasswordModel model)
		{
			var currentUser = userService.GetFromSession(GetAPIKey());
			if (!userService.CheckPassword(currentUser.Id, model.OldPassword))
				return BadRequest("Old Password is incorrect");
			userService.SetPassword(currentUser.Id, model.NewPassword);
			return Ok();
		}
	}
}