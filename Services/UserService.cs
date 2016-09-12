using System;
using dotapi.Models.Authentication;
using dotapi.Repositories;

namespace dotapi.Services
{
	interface IUserService
	{
		UserModel GetCurrentUser();
		
	}
	
	public class UserService : ServiceBase, IUserService
	{
		public UserService(DatabaseContext context)
			: base(context)
		{ }
		
		public UserModel GetCurrentUser()
		{
			return null;
		}
		
	}
}