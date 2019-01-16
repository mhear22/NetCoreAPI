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
	}

	public class EmailService : ServiceBase, IEmailService
	{
		private ICurrentUserService currentUserService;
		private IEmailTemplateService emailTemplateService;
		private IAmazonSimpleEmailService simpleEmail;

		public EmailService(
			IContext context,
			ICurrentUserService currentUserService,
			IEmailTemplateService emailTemplateService,
			IAmazonSimpleEmailService simpleEmail
		) : base(context)
		{
			this.currentUserService = currentUserService;
			this.emailTemplateService = emailTemplateService;
			this.simpleEmail = simpleEmail;
		}

		private void SendPlainEmail(string ToAddress,string EmailHtml, string Subject = "Test Email")
		{
			var email = new SendEmailRequest()
			{
				Source = "mhear22@gmail.com",
				Destination = new Destination()
				{
					ToAddresses = new List<string> { ToAddress }
				},
				Message = new Message()
				{
					Subject = new Content(Subject),
					Body = new Body()
					{
						Html = new Content()
						{
							Charset = "UTF-8",
							Data = EmailHtml
						}
					}
				}
			};

			using (var client = new AmazonSimpleEmailServiceClient(Startup.creds, RegionEndpoint.USEast1))
			{
				var result = client.SendEmailAsync(email).Result;
			}
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
				SendPlainEmail(user.Email, emailTemplate, Reason);
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
			SendPlainEmail(user.EmailAddress, emailTemplate);
		}
	}
}
