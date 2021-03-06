using System;
using System.Net;
using Xunit;

namespace CoreAppTests.Actions.Auth
{
	public class GetUserActionTests : AuthenticationActionTestBase
	{
		[Fact]
		public void GetUserAction_WithNoUsers_Returns404()
		{
			var request = _users.GetUserRequest(Guid.NewGuid().ToString());
			
			Assert.True(request.StatusCode == HttpStatusCode.NotFound);
		}
		
		[Fact]
		public void GetUserAction_WithUsers_Returns200FromEmail()
		{
			_users.Generate(TestModel);
			
			var response = _users.GetUser(TestModel.EmailAddress);
			
			Assert.True(response.EmailAddress == TestModel.EmailAddress);
		}
	}
}