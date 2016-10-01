using System.Linq;
using dotapi.Models.Authentication;
using dotapi.Services;
using Xunit;

namespace dotapi.Tests
{
	public class AuthenticationServiceTest : ServiceTestBase
	{
		private IAuthenticationService _service
		{
			get 
			{
				return new AuthenticationService(Context, new PasswordService(Context), new TokenService(Context));
			}
		}
		
		private CreateUserModel TestModel = new CreateUserModel()
		{
			Email = "test@test.com",
			Password = "password",
			Username = "test"
		};
		
		
		[Fact]
		public void AuthService_WithValidCreds_CreatesUser()
		{
			_service.CreateUser(TestModel);
			
			var row = Context.Users.Where(x=>x.EmailAddress == TestModel.Email);
			
			Assert.True(row != null,"Row not created");
		}
		
		[Fact]
		public void AuthService_Get_CanFindUser()
		{
			_service.CreateUser(TestModel);
			
			var result = _service.Get(TestModel.Username);
			
			Assert.NotNull(result);
		}
		
		[Fact]
		public void AuthService_WithValidCreds_CanLogin()
		{
			_service.CreateUser(TestModel);
			
			var response = _service.Login(new LoginModel(){
				Username = TestModel.Email,
				Password = TestModel.Password
			});
			
			Assert.True(response != null,"Could not check password correctly");
		}
	}
}