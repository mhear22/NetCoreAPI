using CoreApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Forms.CarService
{
	public class CarReport: ReportBase
	{
		public CarReport(IContext Context)
			:base(Context)
		{

		}

		public override object Build(string Id, object Data = null)
		{
			throw new NotImplementedException();
		}
	}
}
