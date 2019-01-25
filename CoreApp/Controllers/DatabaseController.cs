using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace CoreApp.Controllers
{
	public class DatabaseController : ApiController
	{
		private IConfiguration Configuration;
		public DatabaseController(IContext context, IConfiguration Configuration)
			: base(context)
		{
			this.Configuration = Configuration;
		}

		[HttpGet]
		[Route("database/status")]
		[ProducesResponseType(200, Type=typeof(DatabaseInfo))]
		public IActionResult GetDatabase()
		{
			var result = new DatabaseInfo();

			if(Context != null)
				result.ContextExists = true;

			var config = this.Configuration.GetConnectionString("DefaultConnection");
			if(!string.IsNullOrWhiteSpace(config))
			{
				var split = config.Split(';');
				var first = split.Where(x=>x.Contains("server"));
				result.ConfigString = first.FirstOrDefault();
			}

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
		public string ConfigString;
	}
}
