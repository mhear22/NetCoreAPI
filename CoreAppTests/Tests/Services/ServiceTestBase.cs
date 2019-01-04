using System;
using System.Linq;
using CoreApp.Repositories;
using CoreApp;
using CoreApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using CoreAppTests.Tests.Fixtures;

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
			var cus = new TestCurrentUserService();

			provider = new ServiceCollection()
				.AddEntityFrameworkInMemoryDatabase()
				.RegisterService()
				.AddScoped<IContext>(x=> { return Context; })
				.AddScoped<ICurrentUserService>(x=> { return cus; })
				.BuildServiceProvider();

			var builder = new DbContextOptionsBuilder<DatabaseContext>();
			builder.UseInMemoryDatabase("Test")
				.UseInternalServiceProvider(provider);
			options = builder.Options;

			Context.Countries.AddRange(StaticData.Countries);
			Context.VinWMIs.AddRange(StaticData.WorldManufactuerIdenifier);
			Context.Manufacturers.AddRange(StaticData.Manufacturers);
			Context.RepeatTypes.AddRange(StaticData.RepeatingTypes);
			Context.ServiceTypes.AddRange(StaticData.ServiceTypes);
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