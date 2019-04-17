using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using CoreApp.Repositories;

namespace CoreApp.Services
{
	public interface IEmailSendService
	{
		void SendPlainEmail(string ToAddress, string EmailHtml, string Subject = "Test Email");
	}

	public class EmailSendService : ServiceBase, IEmailSendService
	{
		public EmailSendService(IContext context)
			: base(context)
		{
		}

		public void SendPlainEmail(string ToAddress, string EmailHtml, string Subject = "Test Email")
		{
			var email = new SendEmailRequest()
			{
				Source = "noreply@mechie.net",
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
			if (Startup.creds.GetCredentials() == null)
				return;

			using (var client = new AmazonSimpleEmailServiceClient(Startup.creds, RegionEndpoint.USEast1))
			{
				var result = client.SendEmailAsync(email).Result;
			}
		}
	}
}
