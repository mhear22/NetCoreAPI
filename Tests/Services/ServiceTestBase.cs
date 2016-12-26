using System;
using dotapi.Repositories;
using dotapi.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace dotapi.Tests.Services
{
	public class ServiceTestBase
	{
		private DbContextOptions<DatabaseContext> options;
		protected DatabaseContext Context
		{
			get 
			{
				return new DatabaseContext(options);
			}
		}
		public ServiceTestBase()
		{
			var ServiceProvider = new ServiceCollection()
				.AddEntityFrameworkInMemoryDatabase()
				.BuildServiceProvider();
			var builder = new DbContextOptionsBuilder<DatabaseContext>();
			builder.UseInMemoryDatabase()
				.UseInternalServiceProvider(ServiceProvider);
			options = builder.Options;
		}
	}
	
	public class ServiceTestBase<T> : ServiceTestBase
		where T: ServiceBase
	{
		protected T Service;
		public ServiceTestBase(Func<T> ServiceConstuctor)
		{
			Service = ServiceConstuctor();
		}
		
		public ServiceTestBase(Func<DatabaseContext, T> ServiceConstuctor)
		{
			Service = ServiceConstuctor(Context);
		}
	}
}