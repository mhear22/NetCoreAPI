using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;
using HandlebarsDotNet;

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
		
		private object BuildReportData(string ReportType, object Data = null)
		{
			return new { };
		}

		public string GenerateHtml(string ReportType, object Data = null)
		{
			var html = this.htmlDocumentService.GetDocument(ReportType);
			if(html == null)
				throw new ArgumentException($"Could not find a report called {ReportType}");
			var template = Handlebars.Compile(html);
			var data = BuildReportData(ReportType, Data);
			return template(data);
		}
	}
}
