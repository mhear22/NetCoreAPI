using System;
using System.Linq;
using dotapi.Models.Authentication;
using dotapi.Models.Repositories;
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
		public TokenService(DatabaseContext context) : base(context) { }
		
        public string Create(string UserId)
        {
			var token = Guid.NewGuid().ToString();
			
			Context.sessions.Add(new SessionDto(){
				Id = token,
				UserId = UserId,
				SetTime = DateTime.Now.ToUniversalTime()
			});
			
			Context.SaveChanges();
			
			return token;
        }

        public TokenModel Get(string Token)
        {
			return Context.sessions
				.FirstOrDefault(x=>x.Id == Token)
				.ToModel();
        }
    }
}