using System;
using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CoreApp.Tests.Services
{
	public class ServiceTestBase
	{
		private DbContextOptions<DatabaseContext> options;
		protected IServiceProvider provider;
		protected DatabaseContext Context
		{
			get 
			{
				return new DatabaseContext(options);
			}
		}
		public ServiceTestBase()
		{
			provider = new ServiceCollection()
				.AddEntityFrameworkInMemoryDatabase()
				.BuildServiceProvider();
			var builder = new DbContextOptionsBuilder<DatabaseContext>();
			builder.UseInMemoryDatabase()
				.UseInternalServiceProvider(provider);
			options = builder.Options;
		}
	}
	
	public class ServiceTestBase<T> : ServiceTestBase
		where T: ServiceBase
	{
		protected T Service;
		
		public ServiceTestBase(Func<DatabaseContext, T> ServiceConstuctor)
			: base()
		{
			Service = ServiceConstuctor(Context);
		}
	}
}