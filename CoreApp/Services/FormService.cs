using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Services
{
	public interface IFormService
	{
		IActionResult GenerateForm(string Type, string Format, object Data = null);
	}

	public class FormService : ServiceBase, IFormService
	{
		private IEmailTemplateService emailTemplateService;
		private IPdfService pdfService;
		private IHtmlService htmlService;

		public FormService(
			IContext context,
			IEmailTemplateService emailTemplateService,
			IPdfService pdfService,
			IHtmlService htmlService
		) : base(context)
		{
			this.emailTemplateService = emailTemplateService;
			this.pdfService = pdfService;
			this.htmlService = htmlService;
		}

		public IActionResult GenerateForm(string Type, string Format, object Data = null)
		{
			switch (Format.ToLower())
			{
				case "pdf":
					return new FileContentResult(this.pdfService.GeneratePDF(Type, Data),"application/pdf");
				case "email":
					return new ContentResult()
					{
						Content = this.emailTemplateService.GenerateEmailHtml(Type, Data),
						ContentType = "text/html",
						StatusCode = 200
					};
				case "html":
				default:
					return new ContentResult()
					{
						Content = this.htmlService.GenerateHtml(Type, Data),
						StatusCode = 200,
						ContentType = "text/html"
					};
			}
		}
	}
}
