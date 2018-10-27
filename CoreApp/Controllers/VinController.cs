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
	public class VinController : ApiController
	{
		private IVinService vinService;

		public VinController(
			IContext context,
			IVinService vinService
		) : base(context)
		{
			this.vinService = vinService;
		}

		[Route("vin/{Vin}")]
		[HttpGet]
		[ProducesResponseType(200, Type = typeof(CarModel))]
		public IActionResult GetVin(string Vin)
		{
			var model = this.vinService.GetCar(Vin);
			if(model == null)
				return NotFound();
			return Ok(model);
		}
	}
}
