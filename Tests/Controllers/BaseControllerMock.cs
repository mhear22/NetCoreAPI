using System;
using dotapi.Controllers;
using dotapi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;

namespace dotapi.Tests.Controllers
{
	public class BaseControllerMock<T>
		where T : ApiController
	{
		protected T Controller;
		protected IContext Context;
		
		public BaseControllerMock(Func<IContext, T> Method)
		{
			Initialise();
			var controller = Method(Context);
			controller.ControllerContext = new ControllerContext();
			Controller = controller;
		}
		
		private void Initialise()
		{
			var ServiceProvider = new ServiceCollection()
				.AddEntityFrameworkInMemoryDatabase()
				.BuildServiceProvider();
			var builder = new DbContextOptionsBuilder<DatabaseContext>();
			builder
				.UseInMemoryDatabase()
				.UseInternalServiceProvider(ServiceProvider);
			Context = new DatabaseContext(builder.Options);
		}
	}
}