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
	public class MileageController : ApiController
	{
		public IMileageService mileageService;

		public MileageController(
			IContext context,
			IMileageService mileageService
		) : base(context)
		{
			this.mileageService = mileageService;
		}

		[HttpPost]
		[Route("car/mileage/")]
		[ProducesResponseType(200, Type=typeof(void))]
		public IActionResult UpdateMileage([FromBody]MileageModel model)
		{
			this.mileageService.UpdateMileage(model);
			return Ok();
		}
	}
}
