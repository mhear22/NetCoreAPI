using System.Linq;
using dotapi.Models.Authentication;
using dotapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions.User
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
			var duplicates = S<IAuthenticationService>().GetDuplicates(model)
				.Where(x=>x.Id != model.Id)
				.ToList();
			if(duplicates.Count != 0)
				return BadRequest("Username already taken");
			return null;
		}
		
		public IActionResult UpdateUser(string Id, UserModel model)
		{
			return Ok(S<IAuthenticationService>().UpdateUser(Id, model));
		}
	}
}