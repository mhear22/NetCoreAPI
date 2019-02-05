using CoreApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models.Vehicle
{
	public class ReceiptModel
	{
		public string Id;
		public string ServiceType;
		public string RepeatType;
		public string RepeatFrequency;
		public bool Repeating { get { return !string.IsNullOrWhiteSpace(this.RepeatType); } }
		public ServiceReceiptModel LastChange;
		public double Health;
	}
}
