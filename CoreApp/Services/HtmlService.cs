using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;

namespace CoreApp.Services
{
	public interface IHtmlService
	{
		string GenerateHtml(string ReportType, object Data = null);
	}

	public class HtmlService : ServiceBase, IHtmlService
	{
		private IHtmlDocumentService htmlDocumentService;

		public HtmlService(
			IContext context,
			IHtmlDocumentService htmlDocumentService
		) : base(context)
		{
			this.htmlDocumentService = htmlDocumentService;
		}
		
		public string GenerateHtml(string ReportType, object Data = null)
		{
			if (ReportType.ToLower() == "test")
			{
				return @"
<html>
<body>
<h1>Hello World</h1>
</body>
</html>
";
			}
			else
				return this.htmlDocumentService.GetDocument(ReportType);

			throw new ArgumentException($"Could not find a report called {ReportType}");
		}
	}
}
