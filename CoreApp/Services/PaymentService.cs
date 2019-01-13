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
		public PaymentService(
			IContext context,
			ICurrentUserService currentUserService
		) : base(context)
		{
			this.currentUserService = currentUserService;
		}

		public void ProcessPayment(PaymentModel model)
		{
			var customers = new CustomerService();
			var charges = new ChargeService();

			//var currentUser

			var customer = customers.Create(new CustomerCreateOptions
			{
				Email = model.Token.email,
				SourceToken = model.Token.id
			});

			var charge = charges.Create(new ChargeCreateOptions
			{
				Amount = 100,
				Description = "Test Charge",
				Currency = "aud",
				CustomerId = customer.Id
			});
		}
	}
}
