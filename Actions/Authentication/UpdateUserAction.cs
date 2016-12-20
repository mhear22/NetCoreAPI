using dotapi.Models.Authentication;
using dotapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions.Authentication
{
	public class UpdateUserAction : UserAction
	{
		public UpdateUserAction(string UserIdOrName, UserModel model)
		{
			AddAction(() => UserByNameOrId(UserIdOrName));
			AddAction(() => ValidateModel(model));
			AddAction(() => UpdateUser(User.Id,model));
		}
		
		public IActionResult ValidateModel(UserModel model)
		{
			if(model==null)
				return BadRequest("No Data");
			var duplicate = S<IAuthenticationService>().Get(model.Username);
			if(duplicate == null)
				return null;
			return BadRequest("Username already taken");
		}
		
		public IActionResult UpdateUser(string Id, UserModel model)
		{
			return Ok(S<IAuthenticationService>().UpdateUser(Id, model));
		}
	}
}