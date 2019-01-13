using CoreApp.Models.Payments;
using CoreApp.Repositories.Payment;
using CoreApp.Services;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAppTests.Mocks
{
	class MockStripeService : IStripeService
	{
		public Charge HandleCharge(TokenModel model, PaymentPlanDto plan)
		{
			return new Charge();
		}
	}
}
