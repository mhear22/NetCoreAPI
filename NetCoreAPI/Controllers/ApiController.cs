using dotapi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Controllers
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