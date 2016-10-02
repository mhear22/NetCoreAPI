using System;
using System.Net;
using Xunit;

namespace dotapi.Tests.Actions.Auth
{
	public class GetUserActionTests : AuthenticationActionTestBase
	{
		[Fact]
		public void GetUserAction_WithNoUsers_Returns400()
		{
			var request = _users.GetUserRequest(Guid.NewGuid().ToString());
			
			Assert.True(request.StatusCode == HttpStatusCode.BadRequest);
		}
	}
}