using dotapi.Actions.User;
using dotapi.Controllers;
using dotapi.Models.Authentication;
using dotapi.Models.Repositories;
using dotapi.Repositories;
using dotapi.Services;
using Xunit;

namespace dotapi.Tests.Controllers
{
	public class AuthenticationControllerTests : BaseControllerMock<AuthenticationController>
	{
		public AuthenticationControllerTests()
			: base((Context) =>  
			{
				var Token = new TokenService(Context, new Repository<SessionDto>(Context));
				var pass = new PasswordService(Context, new Repository<PasswordDto>(Context));
				var Auth = new AuthenticationService(Context, pass, Token, new Repository<UserDto>(Context));
				var usr = new UserService(Context, Token, pass, Auth);
				return new AuthenticationController(Context, new UserAction(usr));
			})
		{ }
		
		[Fact]
		public void AuthenticationController_WithModel_CreatingUser()
		{
			var model = new CreateUserModel(){
				Username = "test",
				EmailAddress = "test@email.com",
				Password = "password"
			};
			var result = Controller.CreateUser(model);
		}
	}
}