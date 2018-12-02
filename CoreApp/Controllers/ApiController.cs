using System;
using CoreApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace CoreApp.Controllers
{
	public class ApiController : Controller
	{
		protected IContext Context { get; private set; }
		public ApiController(IContext context)
		{
			this.Context = context;
		}
		
		protected IActionResult ReturnResult(Func<object> function) {
			try {
				var data = function();
				return Ok(data);
			}
			catch(ArgumentException ex) {
				return BadRequest(ex.Message);
			}
			catch(UnauthorizedAccessException ex) {
				var resp = StatusCode(401,ex.Message);
				return resp;
			}
			catch(Exception ex) {
				return StatusCode(500, ex.Message);
			}
		}

		protected string GetAPIKey()
		{
			StringValues prim = "";
			try
			{
				Request.Query.TryGetValue("apikey", out prim);
			}
			catch { }
			if(string.IsNullOrWhiteSpace(prim))
			{
				try
				{
					Request.Headers.TryGetValue("apikey", out prim);
				}
				catch { }
			}


			var apikey = prim.ToString();
			return apikey;
		}
	}
}