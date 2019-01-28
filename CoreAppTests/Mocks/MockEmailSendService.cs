using CoreApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAppTests.Mocks
{
	public class MockEmailSendService : IEmailSendService
	{
		public void SendPlainEmail(string ToAddress, string EmailHtml, string Subject = "Test Email")
		{

		}
	}
}
