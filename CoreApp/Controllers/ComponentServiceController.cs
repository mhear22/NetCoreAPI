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
		public ComponentServiceController(
			IContext context
		) : base(context)
		{ }

		[Route("parttypes")]
		[HttpGet]
		[ProducesResponseType(200, Type = typeof(List<ServiceTypeDto>))]
		public IActionResult GetTypes() =>
			ReturnResult(() => Context.ServiceTypes.ToList());

		[Route("repeattypes")]
		[HttpGet]
		[ProducesResponseType(200, Type = typeof(List<RepeatTypeDto>))]
		public IActionResult GetRepeatTypes() =>
			ReturnResult(() => Context.RepeatTypes.ToList());
	}
}
