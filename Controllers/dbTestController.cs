using System.Linq;
using dotapi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Controllers
{
	public class dbTestController : Controller
	{
		private IContext Context;
		public dbTestController(IContext context)
		{
			Context = context;
		}
		
		[HttpGet]
		[Route("db")]
		public IActionResult Get()
		{
			if(Context == null)
				return Ok("Db Down");
			try
			{
				if(Context.users.Count() == 0)
					return Ok("No users");
			}
			catch { return Ok("DB non responding"); }
			return Ok("Db Up");
		}
	}
}