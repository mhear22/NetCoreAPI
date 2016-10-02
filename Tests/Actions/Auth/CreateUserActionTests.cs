using System;
using dotapi.Models.Authentication;
using dotapi.Tests.Fixtures;
using Xunit;

namespace dotapi.Tests.Actions.Auth
{
	public class CreateUserActionTest : AuthenticationActionTestBase
	{
		public CreateUserActionTest() : base() { }
		
		[Fact]
		public void CreateUserAction_WithCorrectCreds_CreatesUser()
		{
			var response = _users.Generate();
			
			Assert.NotNull(response);
			Assert.NotNull(response.Email);
			Assert.NotNull(response.Password);
			Assert.NotNull(response.Username);
		}
		
		[Fact]
		public void CreateUserAction_WithCorrectCreds_CreatesUserWithHardwiredCreds()
		{
			var response = _users.Generate(model);

			Assert.NotNull(response);
		}
		
		[Fact]
		public void CreateUserAction_WithDuplicateCreds_Fails()
		{
			_users.Generate(model);
			
			CreateUserModel result = null;
			try
			{
				result = _users.Generate(model);
			}
			catch { }
			
			Assert.Null(result);
		}
	}
}