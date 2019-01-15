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
		private IPaymentPlanService paymentPlanService;

		public PaymentController(
			IContext context,
			IPaymentService paymentService,
			IPaymentPlanService paymentPlanService
		) : base(context)
		{
			this.paymentService = paymentService;
			this.paymentPlanService = paymentPlanService;
		}

		[HttpPost]
		[Route("payments/")]
		[ProducesResponseType(200, Type = typeof(PaymentModel))]
		public IActionResult ProcessPayment([FromBody]PaymentModel model) =>
			ReturnResult(() => this.paymentService.ProcessPayment(model));

		[HttpGet]
		[Route("paymentplans/")]
		[ProducesResponseType(200, Type=typeof(List<PaymentPlanModel>))]
		public IActionResult GetPlans() =>
			ReturnResult(() => this.paymentPlanService.GetPlans());

		[HttpDelete]
		[Route("payments/{userId}")]
		public IActionResult DeleteSubscription(string userId) =>
			ReturnResult(() => this.paymentService.DropSubscription(userId));
	}
}
