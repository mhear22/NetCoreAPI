using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Forms;
using CoreApp.Forms.CarService;
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
		private IServiceProvider serviceProvider;

		public HtmlService(
			IContext context,
			IHtmlDocumentService htmlDocumentService,
			IServiceProvider serviceProvider
		) : base(context)
		{
			this.serviceProvider = serviceProvider;
			this.htmlDocumentService = htmlDocumentService;
		}
		
		public class ServiceMap {
			public ServiceMap() {
				
			}
			public Type type;
			public string Name;
		}
		
		public class SM<T> : ServiceMap
			where T:ReportBase
		{
			public SM(string Name) {
				this.type = typeof(T);
				this.Name = Name;
			}
		}
		
		private static List<ServiceMap> SMap = new List<ServiceMap>() {
			new SM<CarReport>("carservice")
		};
		
		private object BuildReportData(string ReportType, object Data = null)
		{
			var reportType = HtmlService.SMap.FirstOrDefault(x=>x.Name == ReportType);
			var service = (ReportBase)this.serviceProvider.GetService(reportType.type);
			return service.Build(Data);
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
