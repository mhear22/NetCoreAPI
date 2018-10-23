using System;
using System.Linq;
using CoreApp.Repositories;
using CoreApp;
using CoreApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CoreAppTests.Tests.Services
{
	public class ServiceTestBase
	{
		private DbContextOptions<DatabaseContext> options;
		protected IServiceProvider provider;
		private DatabaseContext privateContext;
		protected DatabaseContext Context
		{
			get 
			{
				if(privateContext == null)
					privateContext = new DatabaseContext(options);
				return privateContext;
			}
		}

		public ServiceTestBase()
		{
			provider = new ServiceCollection()
				.AddEntityFrameworkInMemoryDatabase()
				.RegisterService()
				.AddScoped<IContext>(x=> { return Context; })
				.BuildServiceProvider();
			
			var builder = new DbContextOptionsBuilder<DatabaseContext>();
			builder.UseInMemoryDatabase("Test")
				.UseInternalServiceProvider(provider);
			options = builder.Options;

			Context.Countries.AddRange(StaticData.Countries);
			Context.VinWMIs.AddRange(StaticData.WorldManufactuerIdenifier);
			Context.Manufacturers.AddRange(StaticData.Manufacturers);
			Context.SaveChanges();
		}
	}
	
	public class ServiceTestBase<T> : ServiceTestBase
	{
		protected T Service;
		
		public ServiceTestBase(Func<DatabaseContext, T> ServiceConstuctor)
			: base()
		{
			Service = ServiceConstuctor(Context);
		}

		public ServiceTestBase()
			:base()
		{

			Service = (T)provider.GetService<T>();
		}
	}
}