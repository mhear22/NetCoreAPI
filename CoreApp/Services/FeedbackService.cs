using Amazon.SimpleNotificationService;
using CoreApp.Models.Generic;
using CoreApp.Repositories;
using Microsoft.Extensions.Configuration;

namespace CoreApp.Services
{
	public interface IFeedbackService
	{
		void SubmitFeedback(FeedbackModel model);
	}

	public class FeedbackService : ServiceBase, IFeedbackService
	{
		private IConfiguration Config;
		private IAmazonSimpleNotificationService snsService;
		private IUserService userService;
		public FeedbackService(
			IConfiguration Config,
			IContext context,
			IAmazonSimpleNotificationService snsService,
			IUserService userService
		) : base(context)
		{
			this.userService = userService;
			this.snsService = snsService;
			this.Config = Config;
		}
		
		public void SubmitFeedback(FeedbackModel model)
		{
			var Arn = this.Config.GetSection("FeedbackSNSTopic").Value;
			
			if(string.IsNullOrWhiteSpace(Arn))
			{
				var user = this.userService.GetUser(model.UserId);
				
				var message = $"{user.EmailAddress} said: {model.Feedback} at {model.Url}";
				
				this.snsService.PublishAsync(Arn, message).Wait();
			}
		}
	}
}