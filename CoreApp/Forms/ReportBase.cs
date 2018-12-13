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
		protected Object Data;
		public ReportBase(IContext context)
		{
			this.Context = context;
		}
		
		protected abstract object Execute();
		public object Build(object Data = null) {
			this.Data = Data;
			return this.Execute();
		}
		
		protected T Get<T>(string PropertyName) {
			var type = this.Data.GetType();
			var properties = type.GetProperties();
			var fields = type.GetFields();
			var members = type.GetMembers();
			
			var prop = properties.FirstOrDefault(x=>x.Name == PropertyName);
			var val = prop.GetValue(this.Data);
			return (T)val;
		}
	}
}
