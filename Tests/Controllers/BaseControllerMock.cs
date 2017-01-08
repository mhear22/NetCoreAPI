using System;
using dotapi.Controllers;
using dotapi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;

namespace dotapi.Tests.Controllers
{
	public class BaseControllerMock<T> where T : ApiController
	{
		protected T Controller;
		protected IContext Context;
		
		protected IServiceProvider provider;
		public BaseControllerMock()
		{
			Initialise();
			
			
			Controller = provider.GetService<T>();
		}
		
		private void Initialise()
		{
			provider = new ServiceCollection()
				.AddEntityFrameworkInMemoryDatabase()
				.BuildServiceProvider();
			var builder = new DbContextOptionsBuilder<DatabaseContext>();
			builder
				.UseInMemoryDatabase()
				.UseInternalServiceProvider(provider);
			Context = new DatabaseContext(builder.Options);
		}
	}
}