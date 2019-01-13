using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Models.Payments;
using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Controllers
{
	public class PaymentController : ApiController
	{
		private IPaymentService paymentService;
		public PaymentController(
			IContext context,
			IPaymentService paymentService
		) : base(context)
		{
			this.paymentService = paymentService;
		}

		[HttpPost]
		[Route("payments/")]
		[ProducesResponseType(200, Type = typeof(PaymentModel))]
		public IActionResult ProcessPayment([FromBody]PaymentModel model) =>
			ReturnResult(() => this.paymentService.ProcessPayment(model));
	}
}
