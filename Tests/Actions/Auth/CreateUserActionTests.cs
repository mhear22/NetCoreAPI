using System;
using dotapi.Models.Authentication;
using dotapi.Tests.Fixtures;
using Xunit;

namespace dotapi.Tests.Actions.Auth
{
	public class CreateUserActionTest : ActionTestBase
	{
		private UserFixture _users;
		
		public CreateUserActionTest()
			: base()
		{
			_users = new UserFixture(_client);
		}
		
		private CreateUserModel model = new CreateUserModel()
		{
			Password = "abcd",
			Username = "test",
			Email = "test@test.com"
		};
		
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