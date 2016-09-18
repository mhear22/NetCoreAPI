using dotapi.Models.Authentication;
using Xunit;

namespace dotapi.Tests.Actions
{
	public class CreateUserActionTest : ActionTestBase
	{
		
		public CreateUserActionTest(){ }
		
		[Fact]
		public void CreateSingleUser()
		{
			var model = new CreateUserModel()
			{
				Username = "test",
				Email = "test@test.com",
				Password = "password"
			};
			var response = Post("/users", model);
			
			Assert.True(response != null);
		}
	}
}