using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;

namespace CoreApp.Forms.Test
{
	public class TestReport : ReportBase
	{
		public TestReport(IContext context)
			: base(context)
		{
		}

		protected override object Execute()
		{
			return new {
				
			};
		}
	}
}
