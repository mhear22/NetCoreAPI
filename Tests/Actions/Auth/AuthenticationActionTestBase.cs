using dotapi.Models.Authentication;
using dotapi.Tests.Fixtures;
using Xunit;

namespace dotapi.Tests.Actions
{
	public abstract class AuthenticationActionTestBase : ActionTestBase
	{
		internal UserFixture _users;
		public AuthenticationActionTestBase() 
			: base()
		{
			this._users = new UserFixture(_client);
		}
		
		internal CreateUserModel model = new CreateUserModel()
		{
			Password = "abcd",
			Username = "test",
			Email = "test@test.com"
		};
		
	}
}