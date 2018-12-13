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
		public IActionResult GetForm([FromQuery]object Data, string Type, string Format) => 
			ReturnResult(() => this.formService.GenerateForm(Type, Format, Data));
		
		[Route("generator/types")]
		[HttpGet]
		public IActionResult GetTypes() => ReturnResult(() => this.formService.FormFormats());
		
		
		[Route("generator/forms")]
		[HttpGet]
		public IActionResult GetForms() => ReturnResult(()=> this.formService.FormTypes());
	}
}
