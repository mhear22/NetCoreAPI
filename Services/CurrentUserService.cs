using dotapi.Models.Authentication;
using dotapi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace dotapi.Services
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
			Request.Query.TryGetValue("api_key", out prim);
			var apikey = prim.ToString();
			var model = tokenService.Get(apikey);
			if(model == null){return null;}
			return userService.GetUser(model.UserId);
		}
	}
}