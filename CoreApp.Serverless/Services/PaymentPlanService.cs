using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;

namespace CoreApp.Services
{
	public interface IPaymentPlanService
	{
		List<PaymentPlanModel> GetPlans();
	}

	public class PaymentPlanService : ServiceBase, IPaymentPlanService
	{
		IStripeService stripeService;
		public PaymentPlanService(
			IContext context,
			IStripeService stripeService
		) : base(context)
		{
			this.stripeService = stripeService;
		}

		public List<PaymentPlanModel> GetPlans()
		{
			return this.stripeService.GetPlans().Select(x => new PaymentPlanModel()
			{
				Amount = x.Amount.ToString(),
				Name = x.Nickname,
				Id = x.Id
			}).ToList();
		}
	}

	public class PaymentPlanModel
	{
		public string Id;
		public string Name;
		public string Description;
		public string Amount;
	}
}
