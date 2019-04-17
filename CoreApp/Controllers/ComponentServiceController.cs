using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Models.Vehicle;
using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Controllers
{
	public class ComponentServiceController : ApiController
	{
		private IServiceTypeService serviceTypeService;
		public ComponentServiceController(
			IContext context,
			IServiceTypeService serviceTypeService
		) : base(context)
		{
			this.serviceTypeService = serviceTypeService;
		}

		[Route("parttypes")]
		[HttpGet]
		[ProducesResponseType(200, Type = typeof(List<ServiceTypeModel>))]
		public IActionResult GetTypes() =>
			ReturnResult(() => this.serviceTypeService.GetTypes());

		[Route("repeattypes")]
		[HttpGet]
		[ProducesResponseType(200, Type = typeof(List<RepeatTypeModel>))]
		public IActionResult GetRepeatTypes() =>
			ReturnResult(() => this.serviceTypeService.GetRepeats());
	}
}
