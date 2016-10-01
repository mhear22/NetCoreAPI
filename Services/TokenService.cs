using System;
using dotapi.Models.Authentication;
using dotapi.Repositories;

namespace dotapi.Services
{
	public interface ITokenService
	{
		TokenModel Get(string Token);
		string Create(string UserId);
	}
    public class TokenService : ServiceBase, ITokenService
    {
		public TokenService(IDatabaseContext context) : base(context) { }
		
        public string Create(string UserId)
        {
            throw new NotImplementedException();
        }

        public TokenModel Get(string Token)
        {
            throw new NotImplementedException();
        }
    }
}