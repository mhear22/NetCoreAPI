using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Controllers
{
	public class PaymentController : ApiController
	{
		public PaymentController(IContext context)
			: base(context)
		{
		}

		[HttpPost]
		[Route("payments/")]
		[ProducesResponseType(200, Type=typeof(PaymentModel))]
		public IActionResult ProcessPayment([FromBody]PaymentModel model) => ReturnResult(() =>
		{
			return model;
		});
	}

	public class PaymentModel
	{
		public object Token;
		public string Amount;
	}
}
