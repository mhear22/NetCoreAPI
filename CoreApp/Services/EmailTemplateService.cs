using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace CoreApp.Services
{
	public interface IEmailTemplateService
	{
		string GenerateEmailHtml(string ReportType, IEnumerable<KeyValuePair<string, StringValues>> Data = null);
	}

	public class EmailTemplateService : ServiceBase, IEmailTemplateService
	{
		private IHtmlService htmlService;
		public EmailTemplateService(IContext context, IHtmlService htmlService)
			: base(context)
		{
			this.htmlService = htmlService;
		}

		public string GenerateEmailHtml(string ReportType, IEnumerable<KeyValuePair<string, StringValues>> Data = null)
		{
			return this.htmlService.GenerateHtml(ReportType, Data);
		}
	}
}
