using CoreApp.Models.Authentication;
using CoreApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAppTests.Fixtures
{
	class TestCurrentUserService : ICurrentUserService
	{
		private static string userId = Guid.NewGuid().ToString();

		public UserModel CurrentUser()
		{
			return new UserModel()
			{
				EmailAddress = "test@test.com",
				Id = userId,
				Username = "Test User"
			};
		}

		public string GetSessionKey()
		{
			throw new NotImplementedException();
		}

		public string UserId()
		{
			return userId;
		}
	}
}
