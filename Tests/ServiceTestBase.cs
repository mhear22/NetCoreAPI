using dotapi.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace dotapi.Tests
{
	public class ServiceTestBase
	{
		internal DatabaseContext Context;
		public ServiceTestBase()
		{
			var ServiceProvider = new ServiceCollection()
				.AddDbContext<DatabaseContext>()
				.BuildServiceProvider();
			var builder = new DbContextOptionsBuilder<DatabaseContext>();
			builder.UseInMemoryDatabase()
				.UseInternalServiceProvider(ServiceProvider);
            Context = new DatabaseContext(builder.Options);
		}
	}
}