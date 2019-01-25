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
		public Subscription CancelSub(string SubId)
		{
			throw new NotImplementedException();
		}

		public Customer CreateCustomer(string Email, string SourceToken)
		{
			throw new NotImplementedException();
		}

		public Subscription CreateSubscription(string PlanId, string CustomerId)
		{
			throw new NotImplementedException();
		}

		public Subscription CurrentSubForCustomer(string CustomerId)
		{
			throw new NotImplementedException();
		}

		public List<Plan> GetPlans()
		{
			throw new NotImplementedException();
		}

		public Charge HandleCharge(TokenModel model, string PlanId)
		{
			throw new NotImplementedException();
		}

		public bool StripeStatus()
		{
			throw new NotImplementedException();
		}
	}
}
