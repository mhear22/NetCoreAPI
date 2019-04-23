using CoreApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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

			Assert.NotNull(document);
		}
	}
}
