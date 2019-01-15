using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Models.Payments;
using CoreApp.Repositories;
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
			var userDto = Context.Users.FirstOrDefault(x => x.Id == user.Id);
			var plan = stripeService.GetPlans().FirstOrDefault(x => x.Id == model.PlanId);


			if(userDto.StripeId == null)
			{
				var customer = stripeService.CreateCustomer(model.Token.email, model.Token.id);
				userDto.StripeId = customer.Id;
				Context.SaveChanges();
			}
			else
			{
				var currentSub = stripeService.CurrentSubForCustomer(userDto.StripeId);
				if(currentSub != null)
				{
					stripeService.CancelSub(currentSub.Id);
				}
			}
			stripeService.CreateSubscription(plan.Id, userDto.StripeId);
		}
	}
}
