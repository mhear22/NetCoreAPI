using dotapi.Models.Authentication;
using Xunit;

namespace dotapi.Tests.Actions.Auth
{
	public class UpdateUserActionTest : AuthenticationActionTestBase
	{
		[Fact]
		public void UpdateUserAction_WithCorrectCreds_UpdateUser()
		{
			var response = _users.Generate();
			
			UserModel update = new UserModel()
			{
				Id = response.Id,
				Username = response.Username + "abcd",
				EmailAddress = response.EmailAddress
			};
			
			var result = _users.Update(response.Id, update);
			
			Assert.NotNull(result);
			Assert.NotNull(result.Id);
			Assert.NotNull(result.Username);
			Assert.NotNull(result.EmailAddress);
			Assert.Equal(update.Username, result.Username);
		}
	}
}