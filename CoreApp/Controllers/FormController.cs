using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Controllers
{
	public class FormController : ApiController
	{
		private IFormService formService;
		public FormController(
			IContext context,
			IFormService formService
		) : base(context)
		{
			this.formService= formService;
		}

		[Route("gen/{Type}/{Format}/")]
		[HttpGet]
		public IActionResult GetForm([FromBody]object Data, string Type, string Format)
		{
			return this.formService.GenerateForm(Type, Format, Data);
		}
	}
}
