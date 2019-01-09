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
		private IComponentService componentService;
		public ComponentServiceController(
			IContext context,
			IComponentService componentService
		) : base(context)
		{
			this.componentService = componentService;
		}

		[Route("car/{Vin}/parts")]
		[HttpGet]
		[ProducesResponseType(200, Type = typeof(List<ServiceItem>))]
		public IActionResult GetParts(string Vin) =>
			ReturnResult(() => this.componentService.GetForVin(Vin));

		[Route("car/{Vin}/parts")]
		[HttpPost]
		[ProducesResponseType(200, Type = typeof(void))]
		public IActionResult AddPart(string Vin, [FromBody]ServiceItem item) =>
			ReturnResult(() => this.componentService.AddServiceItem(Vin, item));

		[Route("car/{Vin}/parts/{Id}")]
		[HttpDelete]
		[ProducesResponseType(200, Type = typeof(void))]
		public IActionResult DeletePart(string Vin, string Id) =>
			ReturnResult(() => this.componentService.DeleteServiceItem(Id));

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
