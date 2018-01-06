using CoreApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Controllers
{
	public class ApiController : Controller
	{
		protected IContext Context { get; private set;}
		public ApiController(IContext context)
		{
			this.Context = context;
		}
	}
}