using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.Extensions.Primitives;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using Amazon;

namespace CoreApp.Services
{
	public interface IEmailService
	{
		void SendTestEmail(string Vin);
		void SendServiceEmail(string Vin, string Reason);
		void SendSignUpEmail(string UserId);
	}

	public class EmailService : ServiceBase, IEmailService
	{
		private ICurrentUserService currentUserService;
		private IEmailTemplateService emailTemplateService;
		private IEmailSendService emailSendService;

		public EmailService(
			IContext context,
			ICurrentUserService currentUserService,
			IEmailTemplateService emailTemplateService,
			IEmailSendService emailSendService
		) : base(context)
		{
			this.emailSendService = emailSendService;
			this.currentUserService = currentUserService;
			this.emailTemplateService = emailTemplateService;
		}
		
		public void SendServiceEmail(string Vin, string Reason)
		{
			var users = Context.OwnedCars
				.Where(x => x.Vin == Vin).Select(x => x.Owner)
				.Select(x => new { Email = x.EmailAddress, ApiKey = x.sessions.OrderBy(z=>z.SetTime).FirstOrDefault().Id })
				.ToList();
			foreach(var user in users)
			{
				var data = new List<KeyValuePair<string, StringValues>>();
				data.Add(new KeyValuePair<string, StringValues>("apikey", new StringValues(user.ApiKey)));
				data.Add(new KeyValuePair<string, StringValues>("vin", new StringValues(Vin)));
				var emailTemplate = this.emailTemplateService.GenerateEmailHtml("carservice", data);
				this.emailSendService.SendPlainEmail(user.Email, emailTemplate, Reason);
			}
		}

		public void SendTestEmail(string Vin)
		{
			var user = this.currentUserService.CurrentUser();
			var session = this.currentUserService.GetSessionKey();
			var data = new List<KeyValuePair<string, StringValues>>();
			data.Add(new KeyValuePair<string, StringValues>("apikey", new StringValues(session)));
			data.Add(new KeyValuePair<string, StringValues>("vin", new StringValues(Vin)));
			var emailTemplate = this.emailTemplateService.GenerateEmailHtml("carservice", data);
			this.emailSendService.SendPlainEmail(user.EmailAddress, emailTemplate);
		}

		public void SendSignUpEmail(string UserId)
		{
			var user = Context.Users.FirstOrDefault(x => x.Id == UserId);
			var data = new List<KeyValuePair<string, StringValues>>();
			data.Add(new KeyValuePair<string, StringValues>("userId", new StringValues(user.Id)));
			var html = this.emailTemplateService.GenerateEmailHtml("signup", data);
			this.emailSendService.SendPlainEmail(user.EmailAddress, html, "Welcome to Mechie");
		}
	}
}
