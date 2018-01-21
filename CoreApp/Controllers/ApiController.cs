using CoreApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace CoreApp.Controllers
{
	public class ApiController : Controller
	{
		protected IContext Context { get; private set;}
		public ApiController(IContext context)
		{
			this.Context = context;
		}

		protected string GetAPIKey()
		{
			StringValues prim = "";
			try
			{
				Request.Query.TryGetValue("api_key", out prim);
			}
			catch { }
			var apikey = prim.ToString();
			return apikey;
		}
	}
}