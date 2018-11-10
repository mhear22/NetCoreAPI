using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;
using DinkToPdf;
using DinkToPdf.Contracts;

namespace CoreApp.Services
{
	public interface IPdfService
	{
		byte[] GeneratePDF(string ReportType, object Data);
	}

	public class PdfService : ServiceBase, IPdfService
	{
		private IHtmlService htmlService;
		private IConverter converter;

		public PdfService(
			IContext context,
			IHtmlService htmlService,
			IConverter converter
		) : base(context)
		{
			this.htmlService = htmlService;
			this.converter = converter;
		}

		public byte[] GeneratePDF(string ReportType, object Data)
		{
			var html = this.htmlService.GenerateHtml(ReportType, Data);


			var doc = new HtmlToPdfDocument()
			{
				GlobalSettings = new GlobalSettings() { }
			};

			doc.Objects.Add(new ObjectSettings() {
				HtmlContent = html
			});

			var pdf = converter.Convert(doc);
			return pdf;
		}
	}
}
