using CoreApp.Models.Authentication;
using CoreApp.Models.Repositories;
using CoreApp.Repositories;
using CoreApp.Services;
using System.Linq;
using Xunit;

namespace CoreAppTests.Services
{
	public class AuthenticationServiceTest : ServiceTestBase
	{
		private IAuthenticationService _service
		{
			get
			{
				var pwdrepo = new Repository<PasswordDto>(Context);
				var sess = new Repository<SessionDto>(Context);
				var usr = new Repository<UserDto>(Context);
				
				return new AuthenticationService(Context, new PasswordService(Context, pwdrepo), new TokenService(Context,sess), usr);
			}
		}
		
		private CreateUserModel TestModel = new CreateUserModel()
		{
			EmailAddress = "test@test.com",
			Password = "password",
			Username = "test"
		};
		
		
		[Fact]
		public void AuthService_WithValidCreds_CreatesUser()
		{
			_service.CreateUser(TestModel);
			
			var row = Context.Users.Where(x=>x.EmailAddress == TestModel.EmailAddress);
			
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
			var usr = _service.CreateUser(TestModel);
			this.Get<IUserService>().VerifyUser(usr.Id);
			
			var response = _service.Login(new LoginModel(){
				Username = TestModel.EmailAddress,
				Password = TestModel.Password
			});
			
			Assert.True(response != null,"Could not check password correctly");
		}
	}
}