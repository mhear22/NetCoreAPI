using CoreApp.Models.Authentication;
using CoreApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace CoreApp.Services
{
	public interface ICurrentUserService
	{
		UserModel GetCurrentUser(HttpRequest Request);
	}
	
	public class CurrentUserService: ServiceBase, ICurrentUserService
	{
		private IUserService userService;
		private ITokenService tokenService;
		public CurrentUserService(IContext context, ITokenService token, IUserService userService)
			: base(context)
		{
			this.userService = userService;
			this.tokenService = token;
		}
		
		public UserModel GetCurrentUser(HttpRequest Request)
		{
			StringValues prim = "";
			try
			{
				Request.Query.TryGetValue("api_key", out prim);
			}
			catch { }
			var apikey = prim.ToString();
			var model = tokenService.Get(apikey);
			if(model == null){return null;}
			return userService.GetUser(model.UserId);
		}
	}
}