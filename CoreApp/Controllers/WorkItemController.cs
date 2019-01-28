using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Controllers
{
	public class WorkItemController : ApiController
	{
		public WorkItemController(
			IContext context,
			IWorkItemService workItemService,
			IRepeatingItemService repeatingItemService
		) : base(context)
		{
		}
		
		[Route("part/")]
		[HttpPost]
		[ProducesResponseType(200)]
		public IActionResult CreatePart() => ReturnResult(() => {});
	}
}