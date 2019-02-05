using CoreApp.Models.Vehicle;
using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Controllers
{
	public class WorkItemController : ApiController
	{
		public IWorkItemService workItemService;
		public IRepeatingItemService repeatingItemService;

		public WorkItemController(
			IContext context,
			IWorkItemService workItemService,
			IRepeatingItemService repeatingItemService
		) : base(context)
		{
			this.workItemService = workItemService;
			this.repeatingItemService = repeatingItemService;
		}

		[Route("part/{Id}")]
		[HttpGet]
		[ProducesResponseType(200, Type = typeof(ReceiptModel))]
		public IActionResult GetItem(string Id) =>
			ReturnResult(() => this.workItemService.Get(Id));

		[Route("part/{Id}")]
		[HttpPatch]
		[ProducesResponseType(200)]
		public IActionResult AddReceipt(string Id, [FromBody] string CurrentMiles) =>
			ReturnResult(() => this.workItemService.CompleteWork(Id, CurrentMiles));

		[Route("part/")]
		[HttpPost]
		[ProducesResponseType(200)]
		public IActionResult CreateWorkItem([FromBody]AddWorkItem item) => 
			ReturnResult(() => this.workItemService.AddItem(item));

		[Route("part/{Id}")]
		[HttpDelete]
		[ProducesResponseType(200)]
		public IActionResult DeleteWorkItem(string Id) =>
			ReturnResult(() => this.workItemService.Delete(Id));

		[Route("part/{Id}/repeat")]
		[HttpPost]
		[ProducesResponseType(200)]
		public IActionResult SetRepeat([FromBody]AddRepeatingSettings settings) =>
			ReturnResult(() => this.repeatingItemService.AddRepeatingItem(settings));

		[Route("part/{Id}/repeat")]
		[HttpDelete]
		[ProducesResponseType(200)]
		public IActionResult DeleteRepeat(string Id) =>
			ReturnResult(() => this.repeatingItemService.Delete(Id));
	}
}