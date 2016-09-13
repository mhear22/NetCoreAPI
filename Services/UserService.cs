using System;
using dotapi.Models.Authentication;
using dotapi.Repositories;

namespace dotapi.Services
{
	interface IUserService
	{
		string Create(UserModel model);
		UserModel Get(string Id);
		void Delete(string Id);
		UserModel Update(string Id, UserModel model);
	}
	
	public class UserService : ServiceBase, IUserService
	{
		public UserService(DatabaseContext context)
			: base(context)
		{ }

        public string Create(UserModel model)
        {
			throw new NotImplementedException();
        }

        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public UserModel Get(string Id)
        {
            throw new NotImplementedException();
        }

        public UserModel Update(string Id, UserModel model)
        {
            throw new NotImplementedException();
        }
    }
}