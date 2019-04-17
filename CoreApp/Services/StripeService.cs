using CoreApp.Models.Payments;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Services
{
	public interface IStripeService
	{
		Charge HandleCharge(TokenModel model, string PlanId);
		Customer CreateCustomer(string Email, string SourceToken);
		Subscription CreateSubscription(string PlanId, string CustomerId);
		Subscription CurrentSubForCustomer(string CustomerId);
		Subscription CancelSub(string SubId);
		List<Plan> GetPlans();

		bool StripeStatus();
	}

	public class StripeService : IStripeService
	{
		public bool StripeStatus()
		{
			try
			{
				return new PlanService().List().Any();
			}
			catch
			{
				return false;
			}
		}

		public List<Plan> GetPlans()
		{
			var planService = new PlanService();
			return planService.List().Select(x=>x).ToList();
		}
		
		public Customer CreateCustomer(string Email, string SourceToken)
		{
			return new CustomerService().Create(new CustomerCreateOptions()
			{
				Email = Email,
				SourceToken = SourceToken
			});
		}

		public Subscription CreateSubscription(string PlanId, string CustomerId)
		{
			var subService = new SubscriptionService();
			return subService.Create(new SubscriptionCreateOptions()
			{
				Items = new List<SubscriptionItemOption>()
				{
					new SubscriptionItemOption()
					{
						PlanId = PlanId
					}
				},
				CustomerId = CustomerId
			});
		}

		public Charge HandleCharge(TokenModel model, string PlanId)
		{
			var customers = new CustomerService();
			var charges = new ChargeService();
			var plan = GetPlans().FirstOrDefault(x=>x.Id == PlanId);
			
			var customer = customers.Create(new CustomerCreateOptions
			{
				Email = model.email,
				SourceToken = model.id
			});

			var charge = charges.Create(new ChargeCreateOptions
			{
				Amount = plan.Amount,
				Description = $"//productname {plan.Nickname}",
				Currency = "aud",
				CustomerId = customer.Id
			});

			return charge;
		}

		public Subscription CurrentSubForCustomer(string CustomerId)
		{
			var customerService = new CustomerService();
			var customer = customerService.Get(CustomerId);

			return customer.Subscriptions.FirstOrDefault();
		}

		public Subscription CancelSub(string subId)
		{
			var subService = new SubscriptionService();
			return subService.Cancel(subId, null);
		}
	}
}
