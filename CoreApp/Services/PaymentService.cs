using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Models.Payments;
using CoreApp.Repositories;
using CoreApp.Repositories.Payment;
using Stripe;

namespace CoreApp.Services
{
	public interface IPaymentService
	{
		void ProcessPayment(PaymentModel model);
	}

	public class PaymentService : ServiceBase, IPaymentService
	{
		private ICurrentUserService currentUserService;
		private IPaymentPlanService paymentPlanService;
		private IStripeService stripeService;
		public PaymentService(
			IContext context,
			ICurrentUserService currentUserService,
			IPaymentPlanService paymentPlanService,
			IStripeService stripeService

		) : base(context)
		{
			this.stripeService = stripeService;
			this.paymentPlanService = paymentPlanService;
			this.currentUserService = currentUserService;
		}

		public void ProcessPayment(PaymentModel model)
		{
			var user = currentUserService.CurrentUser();
			var plan = Context.PaymentPlans.FirstOrDefault(x => x.Id == model.PlanId);

			this.stripeService.HandleCharge(model.Token, plan);

			Context.Payments.Add(new PaymentDto()
			{
				CreatedDate = DateTime.UtcNow,
				Id = Guid.NewGuid().ToString(),
				UserId = user.Id,
				PaymentPlanId = plan.Id
			});
			Context.SaveChanges();
		}
	}
}
