using CoreApp.Models.Authentication;
using Xunit;

namespace CoreAppTests.Actions.Auth
{
	public class CreateUserActionTest : AuthenticationActionTestBase
	{
		public CreateUserActionTest() : base() { }

		[Fact]
		public void CreateUserAction_WithCorrectCreds_CreatesUser()
		{
			var response = _users.Generate();
			
			Assert.NotNull(response);
			Assert.NotNull(response.EmailAddress);
			Assert.NotNull(response.Password);
			Assert.NotNull(response.Username);
		}
		
		[Fact]
		public void CreateUserAction_WithCorrectCreds_CreatesUserWithHardwiredCreds()
		{
			var response = _users.Generate(TestModel);

			Assert.NotNull(response);
		}
		
		[Fact]
		public void CreateUserAction_WithDuplicateCreds_Fails()
		{
			_users.Generate(TestModel);
			
			CreateUserModel result = null;
			try
			{
				result = _users.Generate(TestModel);
			}
			catch { }
			
			Assert.Null(result);
		}
	}
}