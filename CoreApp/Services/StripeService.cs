using CoreApp.Models.Payments;
using CoreApp.Repositories.Payment;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Services
{
	public interface IStripeService
	{
		Charge HandleCharge(TokenModel model, PaymentPlanDto plan);
	}

	public class StripeService : IStripeService
	{
		public Charge HandleCharge(TokenModel model, PaymentPlanDto plan)
		{
			var customers = new CustomerService();
			var charges = new ChargeService();

			var customer = customers.Create(new CustomerCreateOptions
			{
				Email = model.email,
				SourceToken = model.id
			});

			var charge = charges.Create(new ChargeCreateOptions
			{
				Amount = plan.Amount,
				Description = $"//productname {plan.Name}",
				Currency = "aud",
				CustomerId = customer.Id
			});

			return charge;
		}
	}
}
