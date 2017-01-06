using dotapi.Actions.User;
using dotapi.Actions.Session;
using dotapi.Models.Authentication;
using Microsoft.AspNetCore.Mvc;
using dotapi.Repositories;

namespace dotapi.Controllers
{
	public class PasswordController : ApiController
	{
		private IUserAction userAction;
        public PasswordController(IContext context, IUserAction userAction) 
			: base(context)
        {
			this.userAction = userAction;
        }

        [Route("user/{userIdOrName}/password")]
		[HttpPost]
		public IActionResult ChangePassword(string userIdOrName,[FromBody]ChangePasswordModel model)
		{
			return userAction.ChangePassword(userIdOrName, model).WithRequest(Request);
		}
	}
}