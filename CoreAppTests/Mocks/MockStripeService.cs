using CoreApp.Models.Payments;
using CoreApp.Services;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAppTests.Mocks
{
	class MockStripeService : IStripeService
	{
		public List<Plan> GetPlans()
		{
			throw new NotImplementedException();
		}

		public Charge HandleCharge(TokenModel model, string PlanId)
		{
			throw new NotImplementedException();
		}
	}
}
