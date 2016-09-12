using dotapi.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace dotapi.Tests
{
	public class ServiceTestBase
	{
		private DbContextOptions<DatabaseContext> options;
		internal DatabaseContext Context
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
}