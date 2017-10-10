using dotapi.Models.Authentication;
using dotapi.Tests.Fixtures;

namespace dotapi.Tests.Actions
{
	public abstract class AuthenticationActionTestBase : TestBase
	{
		internal UserFixture _users;
		public AuthenticationActionTestBase() 
			: base()
		{
			this._users = new UserFixture(_client);
		}
		
		internal CreateUserModel TestModel = new CreateUserModel()
		{
			Password = "abcd",
			Username = "test",
			EmailAddress = "test@test.com"
		};
		
	}
}