using dotapi.Controllers;
using dotapi.Models.Authentication;
using Xunit;

namespace dotapi.Tests.Controllers
{
	public class AuthenticationControllerTests : BaseControllerMock<AuthenticationController>
	{
		public AuthenticationControllerTests()
			: base((Context) =>  new AuthenticationController(Context))
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