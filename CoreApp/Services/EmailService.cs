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

		public void SendTestEmail(string Vin)
		{
			var user = this.currentUserService.CurrentUser();
			var session = this.currentUserService.GetSessionKey();

			var data = new List<KeyValuePair<string, StringValues>>();
			data.Add(new KeyValuePair<string, StringValues>("apikey", new StringValues(session)));
			data.Add(new KeyValuePair<string, StringValues>("vin", new StringValues(Vin)));
			var emailTemplate = this.emailTemplateService.GenerateEmailHtml("carservice", data);


			var email = new SendEmailRequest()
			{
				Source = "mhear22@gmail.com",
				Destination = new Destination()
				{
					ToAddresses = new List<string> { user.EmailAddress }
				},
				Message = new Message()
				{
					Subject = new Content("Test Email"),
					Body = new Body()
					{
						Html = new Content()
						{
							Charset = "UTF-8",
							Data = emailTemplate
						}
					}
				}
			};
			
			using(var client = new AmazonSimpleEmailServiceClient(Startup.creds, RegionEndpoint.USEast1))
			{
				try
				{
					var result = client.SendEmailAsync(email).Result;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex);
				}
			}


		}
	}
}
