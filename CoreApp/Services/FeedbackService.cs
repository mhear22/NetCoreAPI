using CoreApp.Models.Generic;
using CoreApp.Repositories;

namespace CoreApp.Services
{
	public interface IFeedbackService
	{
		void SubmitFeedback(FeedbackModel model);
	}

	public class FeedbackService : ServiceBase, IFeedbackService
	{
		public FeedbackService(IContext context)
			: base(context)
		{
		}
		
		public void SubmitFeedback(FeedbackModel model)
		{
			
		}
	}
}