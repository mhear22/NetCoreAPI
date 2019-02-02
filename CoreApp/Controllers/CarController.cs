using CoreApp.Models.Generic;
using CoreApp.Models.Vehicle;
using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Controllers
{
	public class CarController: ApiController
	{
		private ICarService carService;
		private IWorkItemService workItemService;

		public CarController(
			IContext context,
			ICarService carService,
			IWorkItemService workItemService
		) : base(context)
		{
			this.workItemService = workItemService;
			this.carService = carService;
		}
		
		[Route("car")]
		[HttpPost]
		[ProducesResponseType(200, Type=typeof(string))]
		public IActionResult CreateCar([FromBody] CarCreateModel model)=>
			ReturnResult(() => this.carService.AddCar(model));
		
		[Route("car/{Id}")]
		[HttpGet]
		[ProducesResponseType(200, Type=typeof(OwnedCarModel))]
		public IActionResult GetCar(string Id) => 
			ReturnResult(() => this.carService.Get(Id));
		
		[Route("car/{Id}")]
		[HttpPut]
		[ProducesResponseType(200, Type=typeof(void))]
		public IActionResult UpdateCar(string Id, [FromBody]OwnedCarModel model) => 
			ReturnResult(() => this.carService.Update(Id, model));

		[Route("car/{Id}")]
		[HttpDelete]
		[ProducesResponseType(201, Type =typeof(void))]
		public IActionResult DeleteOwnedCar(string Id) => ReturnResult(() => this.carService.Delete(Id), 201);

		[Route("car/user/{UserId}")]
		[HttpGet]
		[ProducesResponseType(200, Type = typeof(Page<OwnedCarModel>))]
		public IActionResult GetForUser(string UserId) => ReturnResult(() => this.carService.GetForUser(UserId));

		[Route("car/{Id}/parts")]
		[HttpGet]
		[ProducesResponseType(200, Type= typeof(List<ReceiptModel>))]
		public IActionResult GetParts(string Id) => ReturnResult(() => this.workItemService.GetForVin(Id));
	}
}
