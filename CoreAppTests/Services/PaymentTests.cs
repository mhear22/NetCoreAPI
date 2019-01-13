using CoreApp.Models.Payments;
using CoreApp.Services;
using CoreAppTests.Tests.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CoreAppTests.Services
{
	public class PaymentTests: ServiceTestBase<IPaymentService>
	{
		[Fact]
		public void CanProcessPayments()
		{
			var plan = Context.PaymentPlans.FirstOrDefault();

			Service.ProcessPayment(new PaymentModel()
			{
				PlanId = plan.Id,
				Token = new TokenModel()
				{
					email = "test@test.com",
					id = "tok_1Ds3QSK3muD42pMvjklsh8OM"
				}
			});

			var payment = Context.Payments.FirstOrDefault();
			Assert.NotNull(payment);
		}

	}
}
