using CoreApp.Models.Authentication;
using CoreApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAppTests.Tests.Fixtures
{
	class TestCurrentUserService : ICurrentUserService
	{
		public UserModel CurrentUser()
		{
			throw new NotImplementedException();
		}

		public string UserId()
		{
			return Guid.NewGuid().ToString();
		}
	}
}
