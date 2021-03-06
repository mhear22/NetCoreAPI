using CoreApp.Models.Repositories;
using CoreApp.Repositories;
using CoreApp.Services;
using System.Linq;
using Xunit;

namespace CoreAppTests.Services
{
	public class PasswordServiceTest : ServiceTestBase
	{
		private PasswordService _service
		{ 
			get
			{
				return new PasswordService(Context, new Repository<PasswordDto>(Context));
			}
		}
		
		[Fact]
		public void TestHashRespondsCorrectly()
		{
			_service.SetPassword("abc", "testPassword");
			var row = Context.Passwords.FirstOrDefault(x=>x.UserId == "abc");
		
			Assert.True(row != null, "row is null");
			Assert.True(row.Hash != null, "Hash is null");
			Assert.True(row.UserId == "abc", "UserId is wrong");
			
		}
		
		[Fact]
		public void TestHashesAreDifferent()
		{
			_service.SetPassword("a", "password1");
			_service.SetPassword("b", "password2");
			
			var row1 = Context.Passwords.FirstOrDefault(x=>x.UserId == "a");
			var row2 = Context.Passwords.FirstOrDefault(x=>x.UserId == "b");
			
			Assert.True(row1 != null);
			Assert.True(row2 != null);
			Assert.True(row1.Hash != row2.Hash);
		}
		
		[Fact]
		public void TestHashesAreTheSameWithTheSameSalt()
		{
			_service.SetPassword("a", "test");
			var row = Context.Passwords.FirstOrDefault(x=>x.UserId == "a");
			
			Assert.True(_service.CheckPassword("a", "test"),"Passwords are not checked correctly");
		}
	}
}