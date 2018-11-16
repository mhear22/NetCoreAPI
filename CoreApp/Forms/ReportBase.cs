using CoreApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Forms
{
	public abstract class ReportBase
	{
		protected IContext Context;
		public ReportBase(IContext context)
		{
			this.Context = context;
		}

		public abstract object Build(string Id, object Data = null);
	}
}
