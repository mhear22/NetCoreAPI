using System;
using dotapi.Controllers;
using dotapi.Repositories;
using Microsoft.EntityFrameworkCore;

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
			Controller = Method(Context);
		}
		
		private void Initialise()
		{
			var builder = new DbContextOptionsBuilder<DatabaseContext>();
			builder.UseInMemoryDatabase();
			Context = new DatabaseContext(builder.Options);
		}
	}
}