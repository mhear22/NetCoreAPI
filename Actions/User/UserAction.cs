using System.Linq;
using dotapi.Models.Authentication;
using dotapi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace dotapi.Actions.User
{
	public interface IUserAction
	{
		UserAction ChangePassword(string UserIdOrName, ChangePasswordModel model);
		UserAction GetCurrentUserAction();
		UserAction CreateUserAction(CreateUserModel model);
		UserAction UpdateUserAction(string UserIdOrName, UserModel model);
		UserAction LoginAction(LoginModel model);
	}
	public class UserAction : ActionBase, IUserAction
	{
		private IAuthenticationService authService;
		private ICurrentUserService CurrentUserService;
		private IUserService userService;
		public UserAction(IUserService userService, IAuthenticationService auth, ICurrentUserService current)
		{
			this.userService = userService;
			this.authService = auth;
			this.CurrentUserService = current;
			AddAction(() => CurrentUserBySession());
		}
		
		protected UserModel User;
		protected UserModel CurrentUser;
		private IActionResult CurrentUserBySession()
		{
			CurrentUser = CurrentUserService.GetCurrentUser(Request);
			return null;
		}
		
		protected IActionResult UserByNameOrId(string UserNameOrId)
		{
			var user = userService.GetUser(UserNameOrId);
			if(user == null)
				return BadRequest("User Doesnt Exist");
			User = user;
			return null;
		}
		
		public UserAction ChangePassword(string UserIdOrName, ChangePasswordModel model)
		{
			AddAction(() => UserByNameOrId(UserIdOrName));
			AddAction(() => ValidateModel(model));
			AddAction(() => ChangePassword(model));
			return this;
		}
		
		public IActionResult ValidateModel(ChangePasswordModel model)
		{
			//Probably do a role check here instead eventually
			if(User.Id != CurrentUser.Id)
				return Unauthorized("Cant change someone elses password");
				
			if(!userService.CheckPassword(User.Id,model.OldPassword))
				return BadRequest("Old Password is incorrect");
			//Check password Rules here
			return null;
		}
		
		public IActionResult ChangePassword(ChangePasswordModel model)
		{
			userService.SetPassword(User.Id, model.NewPassword);
			return Ok();
		}
		
		public UserAction LoginAction(LoginModel model)
		{
			AddAction(() => UserByNameOrId(model.Username));
			AddAction(() => Login(model));
			return this;
		}
		
		public IActionResult Login(LoginModel model)
		{
			var token = authService.Login(model);
			if(token == null)
				return BadRequest();
			return Ok(token);
		}
		
		public UserAction UpdateUserAction(string UserIdOrName, UserModel model)
		{
			AddAction(() => UserByNameOrId(UserIdOrName));
			AddAction(() => ValidateModel(model));
			AddAction(() => UpdateUser(User.Id,model));
			return this;
		}
		
		public IActionResult ValidateModel(UserModel model)
		{
			if(model==null)
				return BadRequest("No Data");
			var duplicates = authService.GetDuplicates(model)
				.Where(x=>x.Id != model.Id)
				.ToList();
			if(duplicates.Count != 0)
				return BadRequest("Username already taken");
			return null;
		}
		
		public IActionResult UpdateUser(string Id, UserModel model)
		{
			return Ok(authService.UpdateUser(Id, model));
		}
		
		public UserAction CreateUserAction(CreateUserModel model)
		{
			AddAction(() => ValidateModel(model));
			AddAction(() => CreateUser(model));
			return this;
		}
		
		public IActionResult ValidateModel(CreateUserModel model)
		{
			if(model==null)
				return BadRequest("No Data");
			if(string.IsNullOrWhiteSpace(model.EmailAddress) || string.IsNullOrWhiteSpace(model.Password))
				return BadRequest("Email address and password is required");
			var duplicate = authService.Get(model.Username);
			var emailDupe = authService.Get(model.EmailAddress);
			var duplicates = authService.GetDuplicates(model);
			if(duplicates.Count != 0)
				return BadRequest("Username or email address already used");
			if(duplicate != null)
				return BadRequest("Username already taken");
			return null;
		}
		
		public IActionResult CreateUser(CreateUserModel model)
		{
			return Created(authService.CreateUser(model));
		}
		
		public UserAction GetCurrentUserAction()
		{
			AddAction(() => GetCurrentUser());
			return this;
		}
		
		protected IActionResult GetCurrentUser()
		{
			return Ok(CurrentUser);
		}
	}
}