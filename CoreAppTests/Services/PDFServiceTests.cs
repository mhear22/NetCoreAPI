using CoreApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CoreAppTests.Services
{
	public class PDFServiceTests: ServiceTestBase<IPdfService>
	{
		[Fact]
		public void FormService_CanBuild()
		{
			var document = Service.GeneratePDF("test", null);

			var pdf = Encoding.Default.GetString(document);

			
			Assert.Contains("pdf", pdf.ToLower());
		}
	}
}
