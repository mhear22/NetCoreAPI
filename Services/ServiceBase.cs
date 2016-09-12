using dotapi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Services
{
	public class ServiceBase
	{
		public ServiceBase(DatabaseContext context)
		{
			this.Context = context;
		}
		internal DatabaseContext Context { get; set; }
	}
}