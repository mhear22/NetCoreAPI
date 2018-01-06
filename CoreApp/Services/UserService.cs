using CoreApp.Models.Authentication;
using CoreApp.Repositories;

namespace CoreApp.Services
{
	public interface IUserService
	{
		UserModel GetUser(string userId);
		UserModel GetFromSession(string ApiKey);
		bool CheckPassword(string UserId, string password);
		void SetPassword(string userId, string password);
	}
    public class UserService : ServiceBase, IUserService
    {
		private ITokenService tokenService;
		private IAuthenticationService authService;
		private IPasswordService passwordService;
		public UserService(IContext context, ITokenService ts,IPasswordService pass, IAuthenticationService auth) 
			: base(context)
		{
			tokenService = ts;
			authService = auth;
			passwordService = pass;
		}
        public UserModel GetUser(string userId)
        {
			return authService.Get(userId);
		}
		
		public bool CheckPassword(string UserId, string password)
		{
			return passwordService.CheckPassword(UserId, password);
		}
		
		public void SetPassword(string userId, string password)
		{
			passwordService.SetPassword(userId, password);
		}

        public UserModel GetFromSession(string ApiKey)
        {
			var userFromToken = tokenService.Get(ApiKey);
			if(userFromToken == null)
				return null;
			return authService.Get(userFromToken.UserId);
        }
    }
}