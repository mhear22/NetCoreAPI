﻿using System;
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

		[Route("car/{Vin}/part/{Id}")]
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

		[Route("car/{Vin}/part/{Id}")]
		[HttpGet]
		[ProducesResponseType(200, Type = typeof(ServiceItemModel))]
		public IActionResult GetPart(string Vin, string Id) =>
			ReturnResult(() => this.componentService.GetPart(Vin, Id));

		[Route("car/{Vin}/part/{Id}/complete")]
		[HttpPost]
		public IActionResult CompleteWork(string Vin, string Id, [FromBody] PartCompleteModel model) =>
			ReturnResult(() => this.componentService.CompleteWorkOnPart(Vin, Id, model));
	}
}