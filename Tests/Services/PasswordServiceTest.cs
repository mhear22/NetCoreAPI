using dotapi.Services;
using Xunit;

namespace dotapi.Tests
{
	public class PasswordServiceTest : ServiceTestBase
	{
		private IPasswordService _service; 
		public PasswordServiceTest()
		{
			_service = new PasswordService(Context);
		}
		
		[Fact]
		public void TestHash()
		{
		//Given
		
		//When
			Assert.True(false,"Is not true");
		//Then
		}
	}
}