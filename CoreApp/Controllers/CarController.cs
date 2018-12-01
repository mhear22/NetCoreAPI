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

		public CarController(
			IContext context,
			ICarService carService
		) : base(context)
		{
			this.carService = carService;
		}

		[Route("car")]
		[HttpPost]
		[ProducesResponseType(200, Type=typeof(string))]
		public IActionResult CreateCar([FromBody] CarCreateModel model)
		{
			return Ok(this.carService.AddCar(model));
		}

		[Route("car/{Id}")]
		[HttpGet]
		[ProducesResponseType(200, Type=typeof(OwnedCarModel))]
		public IActionResult GetCar(string Id)
		{
			return Ok(this.carService.Get(Id));
		}
		
		[Route("car/{Id}")]
		[HttpPut]
		[ProducesResponseType(200, Type=typeof(void))]
		public IActionResult UpdateCar(string Id, [FromBody]OwnedCarModel model)
		{
			this.carService.Update(Id, model);
			return Ok();
		}

		[Route("car/{Id}")]
		[HttpDelete]
		[ProducesResponseType(201, Type =typeof(void))]
		public IActionResult DeleteOwnedCar(string Id)
		{
			this.carService.Delete(Id);
			return NoContent();
		}

		[Route("car/user/{UserId}")]
		[HttpGet]
		[ProducesResponseType(200, Type = typeof(Page<OwnedCarModel>))]
		public IActionResult GetForUser(string UserId)
		{
			return Ok(this.carService.GetForUser(UserId));
		}
	}
}
