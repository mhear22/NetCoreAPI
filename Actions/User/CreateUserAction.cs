using dotapi.Models.Authentication;
using dotapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions.User
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
			if(model==null)
				return BadRequest("No Data");
			if(string.IsNullOrWhiteSpace(model.EmailAddress) || string.IsNullOrWhiteSpace(model.Password))
				return BadRequest("Email address and password is required");
			var duplicate = S<IAuthenticationService>().Get(model.Username);
			var emailDupe = S<IAuthenticationService>().Get(model.EmailAddress);
			var duplicates = S<IAuthenticationService>().GetDuplicates(model);
			if(duplicates.Count != 0)
				return BadRequest("Username or email address already used");
			if(duplicate != null)
				return BadRequest("Username already taken");
			return null;
		}
		
		public IActionResult CreateUser(CreateUserModel model)
		{
			return Created(S<IAuthenticationService>().CreateUser(model));
		}
	}
}