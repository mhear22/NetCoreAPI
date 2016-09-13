using System.Linq;
using dotapi.Models.Authentication;
using dotapi.Services;
using Xunit;

namespace dotapi.Tests
{
	public class UserServiceTests : ServiceTestBase
	{
		private IUserService _service
		{ 
			get
			{ 
				return new UserService(Context);
			}
		}
		
		[Fact]
		public void CanCreateAUser()
		{
			var model = new UserModel(){
				
			};
			//_service.Create(model);
		}
	}
}