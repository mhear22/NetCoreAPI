using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Controllers
{
	public class DatabaseController : ApiController
	{
		public DatabaseController(IContext context)
			: base(context)
		{
		}

		[HttpGet]
		[Route("database/status")]
		[ProducesResponseType(200, Type=typeof(DatabaseInfo))]
		public IActionResult GetDatabase()
		{
			var result = new DatabaseInfo();

			if(Context != null)
				result.ContextExists = true;
			
			try
			{
				if (Context.VinWMIs.Any())
					result.DbConnection = true;
			}
			catch { }

			return Ok(result);
		}
	}

	public class DatabaseInfo
	{
		public bool ContextExists = false;
		public bool DbConnection = false;
	}
}
