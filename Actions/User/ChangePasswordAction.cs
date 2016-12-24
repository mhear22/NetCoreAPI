using dotapi.Models.Authentication;
using dotapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions.User
{
	public class ChangePasswordAction : UserAction
	{
		public ChangePasswordAction(string UserIdOrName, ChangePasswordModel model)
		{
			AddAction(() => UserByNameOrId(UserIdOrName));
			AddAction(() => ValidateModel(model));
			AddAction(() => ChangePassword(model));
		}
		
		public IActionResult ValidateModel(ChangePasswordModel model)
		{
			var duplicate = S<IAuthenticationService>();
			if(!S<IPasswordService>().CheckPassword(User.Id,model.OldPassword))
				return BadRequest("Old Password is incorrect");
			//Check password Rules here
			return null;
		}
		
		public IActionResult ChangePassword(ChangePasswordModel model)
		{
			S<IPasswordService>().SetPassword(User.Id, model.NewPassword);
			return Ok();
		}
	}
}