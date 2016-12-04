using dotapi.Models.Authentication;
using dotapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions.Authentication
{
	public class CreateUserAction : ActionBase
	{
		public CreateUserAction(CreateUserModel model)
		{
			AddAction(() => ValidateModel(model));
			AddAction(() => CreateUser(model));
		}
		
		public IActionResult ValidateModel(CreateUserModel model)
		{
			var duplicate = S<IAuthenticationService>().Get(model.Username);
			if(duplicate == null)
				return null;
			return BadRequest("Username already taken");
		}
		
		public IActionResult CreateUser(CreateUserModel model)
		{
			return Created(S<IAuthenticationService>().CreateUser(model));
		}
	}
}