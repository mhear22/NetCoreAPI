using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Forms
{	
	public abstract class ReportBase
	{
		public string Domain = Domains.Route;
		public string Api = Domains.Api;

		protected IContext Context;
		protected IEnumerable<KeyValuePair<string, StringValues>> Data;
		public ReportBase(IContext context)
		{
			this.Context = context;
		}
		
		protected abstract object Execute();
		public object Build(IEnumerable<KeyValuePair<string, StringValues>> Data = null) {
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
