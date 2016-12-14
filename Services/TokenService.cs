using System;
using dotapi.Models.Authentication;
using dotapi.Models.Repositories;
using dotapi.Repositories;

namespace dotapi.Services
{
	public interface ITokenService
	{
		TokenModel Get(string Token);
		string Create(string UserId);
		string Delete(string Token);
	}
    public class TokenService : ServiceBase, ITokenService
    {
		private IRepository<SessionDto> sessionRepo; 
		public TokenService(DatabaseContext context, IRepository<SessionDto> sessionRepo) 
			: base(context)
		{
			this.sessionRepo = sessionRepo;
		}
		
        public string Create(string UserId)
        {
			var token = Guid.NewGuid().ToString();
			sessionRepo.Create(new SessionDto(){
				Id = token,
				UserId = UserId,
				SetTime = DateTime.Now.ToUniversalTime()
			});
			return token;
        }

        public string Delete(string Token)
        {
			sessionRepo.Delete(Token);
			return Token;
        }

        public TokenModel Get(string Token)
        {
			return sessionRepo.Get(Token).ToModel();
        }
    }
}