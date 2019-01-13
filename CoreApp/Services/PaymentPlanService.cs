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
		public PaymentPlanService(IContext context)
			: base(context)
		{

		}

		public List<PaymentPlanModel> GetPlans()
		{
			return Context.PaymentPlans.OrderBy(x=>x.Amount).Select(x => new PaymentPlanModel()
			{
				Amount = $"${x.Amount / 100}",
				Description = x.Description,
				Name = x.Name
			}).ToList();
		}
	}

	public class PaymentPlanModel
	{
		public string Name;
		public string Description;
		public string Amount;
	}
}
