using System;
using System.Collections.Generic;
using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace CoreApp.Controllers
{
	public class ApiController : Controller
	{
		protected string Api = Domains.Api;
		protected string Domain = Domains.Route;


		protected IContext Context { get; private set; }
		public ApiController(IContext context)
		{
			this.Context = context;
		}
		
		protected IActionResult ReturnResult(Action function, int responseCode = 200)
		{
			try {
				function();
				return new StatusCodeResult(statusCode:responseCode);
			}
			catch(ArgumentException ex) {
				return BadRequest(ex.Message);
			}
			catch(KeyNotFoundException ex) {
				return StatusCode(404, ex.Message);
			}
			catch(UnauthorizedAccessException ex) {
				var resp = StatusCode(401,ex.Message);
				return resp;
			}
			catch(Exception ex) {
				return StatusCode(500, ex.Message);
			}
		}
		
		protected IActionResult ReturnResult(Func<object> function, int statusCode = 200) {
			try {
				var data = function();
				if(data is IActionResult)
					return (IActionResult)data;
				return StatusCode(statusCode, data);
			}
			catch(ArgumentException ex) {
				return BadRequest(ex.Message);
			}
			catch(KeyNotFoundException ex) {
				return StatusCode(404, ex.Message);
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