using dotapi.Tests.Fixtures;
using Xunit;

namespace dotapi.Tests.Actions
{
	public class CreateUserActionTest : ActionTestBase
	{
		
		public CreateUserActionTest(){ }
		
		[Fact]
		public void CreateSingleUser()
		{
			var fixture = new UserFixture(_client);
			var response = fixture.Generate();
			
			Assert.True(response != null);
		}
	}
}