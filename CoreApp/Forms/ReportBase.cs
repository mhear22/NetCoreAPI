﻿using CoreApp.Repositories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Forms
{	
	public abstract class ReportBase
	{
		protected IContext Context;
		protected IQueryCollection Data;
		public ReportBase(IContext context)
		{
			this.Context = context;
		}
		
		protected abstract object Execute();
		public object Build(IQueryCollection Data = null) {
			this.Data = Data;
			return this.Execute();
		}
		
		protected string Get(string PropertyName) {
			var data = this.Data.FirstOrDefault(x=>x.Key == PropertyName);
			var val = data.Value;
			return val.ToString();
		}
	}
}
