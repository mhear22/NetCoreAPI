using CoreApp.Services;
using CoreApp.Repositories;
using CoreApp.Models.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Controllers
{
	public class FeedbackController: ApiController
	{
		private IFeedbackService feedbackService;
		public FeedbackController(
			IContext context,
			IFeedbackService feedbackService
		) : base(context)
		{
			this.feedbackService = feedbackService;
		}
		
		[HttpPost("feedback")]
		[ProducesResponseType(200)]
		public IActionResult SendFeedback([FromBody]FeedbackModel model) =>
			ReturnResult(() => this.feedbackService.SubmitFeedback(model));
	}
}