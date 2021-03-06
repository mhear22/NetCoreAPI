﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CoreApp.Forms;
using CoreApp.Forms.SignUp;
using CoreApp.Forms.Test;
using CoreApp.Repositories;
using HandlebarsDotNet;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace CoreApp.Services
{
	public interface IHtmlService
	{
		string GenerateHtml(string ReportType, IEnumerable<KeyValuePair<string, StringValues>> Data = null);
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
			new SM<CarReport>("carservice"),
			new SM<SignUpReport>("signup"),
			new SM<TestReport>("test")
		};
		
		private object BuildReportData(string ReportType, IEnumerable<KeyValuePair<string, StringValues>> Data = null)
		{
			var reportType = HtmlService.SMap.FirstOrDefault(x=>x.Name == ReportType);
			if (reportType == null)
				throw new ArgumentException($"Service Map Doesnt contain a {ReportType}");
			var service = (ReportBase)this.serviceProvider.GetService(reportType.type);

			if (service == null)
				throw new ArgumentException("Could not get the report, is it added to the IOC container?");
			return service.Build(Data);
		}
		
		public string GenerateHtml(string ReportType, IEnumerable<KeyValuePair<string, StringValues>> Data = null)
		{
			var html = this.htmlDocumentService.GetDocument(ReportType);
			if(html == null)
				throw new ArgumentException($"Could not find a report called {ReportType}");
			var template = Handlebars.Compile(html);
			try
			{
				var data = BuildReportData(ReportType, Data);
				var response = template(data);
				return response;
			}
			catch(Exception ex)
			{
				throw new ArgumentException($"Could not Run Report, {ex.Message}", ex);
			}
		}
	}
}
