using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Models.Authentication;
using CoreApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace CoreApp.Services
{
	public interface ICurrentUserService
	{
		string UserId();
		UserModel CurrentUser();
		string GetSessionKey();
	}

	public class CurrentUserService : ServiceBase, ICurrentUserService
	{
		private IHttpContextAccessor accessor;
		public CurrentUserService(IContext context, IHttpContextAccessor accessor)
			: base(context)
		{
			this.accessor = accessor;
		}

		public string GetSessionKey()
		{
			StringValues prim = "";
			try
			{
				accessor.HttpContext.Request.Query.TryGetValue("apikey", out prim);
			}
			catch { }
			if (string.IsNullOrWhiteSpace(prim))
			{
				try
				{
					accessor.HttpContext.Request.Headers.TryGetValue("apikey", out prim);
				}
				catch { }
			}

			return prim.ToString();
		}

		public string UserId()
		{
			var apikey = this.GetSessionKey();
			var session = Context.Sessions.FirstOrDefault(x => x.Id == apikey);

			if (session != null)
			{
				return session.UserId;
			}
			else
				throw new ArgumentException("Could not find user, no Api Key");
		}

		public UserModel CurrentUser()
		{
			var userId = UserId();
			return Context.Users
				.FirstOrDefault(x => x.Id == userId).ToModel();
		}
	}
}
