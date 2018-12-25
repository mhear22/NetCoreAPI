using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Services
{
	public interface IFormService
	{
		IActionResult GenerateForm(string Type, string Format, IQueryCollection Data = null);
		IActionResult FormTypes();
		IActionResult FormFormats();
		
	}

	public class FormService : ServiceBase, IFormService
	{
		private IEmailTemplateService emailTemplateService;
		private IPdfService pdfService;
		private IHtmlService htmlService;
		private IHtmlDocumentService htmlDocumentService; 

		public FormService(
			IContext context,
			IEmailTemplateService emailTemplateService,
			IPdfService pdfService,
			IHtmlService htmlService,
			IHtmlDocumentService htmlDocumentService 
		) : base(context)
		{
			this.emailTemplateService = emailTemplateService;
			this.pdfService = pdfService;
			this.htmlService = htmlService;
			this.htmlDocumentService = htmlDocumentService;
		}

		public IActionResult GenerateForm(string Type, string Format, IQueryCollection Data = null)
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
		
		public IActionResult FormFormats()
		{
			var formTypes = new List<string>(){"html","pdf","email"};
			return new OkObjectResult(formTypes);	
		}
		
		public IActionResult FormTypes()
		{
			var names = this.htmlDocumentService.GetDocumentNames();
			return new OkObjectResult(names);
		}
	}
}
