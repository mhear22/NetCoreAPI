using CoreApp.Models.Authentication;
using System.Net;
using Xunit;

namespace CoreAppTests.Tests.Actions.Auth
{
	public class LoginActionTests : AuthenticationActionTestBase
	{
		public LoginActionTests()
		{
			TestLogin = new LoginModel()
			{
				Username = TestModel.Username,
				Password = TestModel.Password
			};
		}
		
		private LoginModel TestLogin;
		
		[Fact]
		public void LoginAction_WithCorrectCreds_ReturnsSessionToken()
		{
			_users.Generate(TestModel);
			
			var login = _users.GetSessionToken(TestLogin);
			
			Assert.NotNull(login);
		}
		
		[Fact]
		public void LoginAction_WithIncorrectPass_ReturnsBadRequest()
		{
			var user = _users.Generate();
			
			var model = new LoginModel()
			{
				Username = user.Username,
				Password = "WrongPassword"
			};
			
			var login = _users.GetSessionTokenRequest(model);
			
			Assert.True(login.StatusCode == HttpStatusCode.BadRequest);
		}
		
		[Fact]
		public void LoginAction_WithNoUser_ReturnsBadRequest()
		{
			var request = _users.GetSessionTokenRequest(new LoginModel(){
				Username = "UnusedUsername",
				Password = "password"
			});
			
			Assert.True(request.StatusCode == HttpStatusCode.BadRequest);
		}
		
		[Fact]
		public void LoginAction_WithCorrectCredsTwice_ReturnsUniqueToken()
		{
			_users.Generate(TestModel);
			
			var login = _users.GetSessionToken(TestLogin);
			
			var login2 = _users.GetSessionToken(TestLogin);
			
			Assert.True(login != login2);
		}
	}
}