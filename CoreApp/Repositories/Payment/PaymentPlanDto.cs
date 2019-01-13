using CoreApp.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Repositories.Payment
{
	public class PaymentPlanDto : IRow
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Amount { get; set; }
		public int MonthsCovered { get; set; }
		public bool Repeatable { get; set; }
	}
}
