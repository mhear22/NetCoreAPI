using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;
using CoreApp.Repositories.Payment;

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
			return Context.PaymentPlans
				.OrderBy(x => x.Amount)
				.ToList()
				.Select(x => x.ToModel())
				.ToList();
		}
	}

	public class PaymentPlanModel
	{
		public string Id;
		public string Name;
		public string Description;
		public string Amount;
	}

	public static class PaymentPlanModelExtentions
	{
		public static PaymentPlanModel ToModel(this PaymentPlanDto dto)
		{
			return new PaymentPlanModel()
			{
				Amount = $"${dto.Amount / 100}",
				Description = dto.Description,
				Name = dto.Name,
				Id = dto.Id
			};
		}
	}
}
