using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;

namespace CoreApp.Forms.SignUp
{
	public class SignUpReport : ReportBase
	{
		public SignUpReport(IContext context)
			: base(context)
		{

		}

		protected override object Execute()
		{
			var userId = Get("userId");

			var user = Context.Users.FirstOrDefault(x => x.Id == userId);

			return new
			{
				user
			};
		}
	}
}
