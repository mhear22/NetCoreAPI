using System.Net;
using Xunit;

namespace dotapi.Tests.Actions
{
	public class AuthenticationActionTest : ActionTestBase
	{
		
		public AuthenticationActionTest(){ }
		
		[Fact]
		public void GetSampleText()
		{
			var result = Get<string>("/status");
			
			Assert.True(result != null);
		}
	}
}