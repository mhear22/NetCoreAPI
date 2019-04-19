using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Amazon.Lambda.Core;
using CoreApp.Repositories;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Http;

namespace CoreApp.Services
{
	public interface IPdfService
	{
		byte[] GeneratePDF(string ReportType, IQueryCollection Data);
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

		public byte[] GeneratePDF(string ReportType, IQueryCollection Data)
		{
			var html = this.htmlService.GenerateHtml(ReportType, Data);


			var doc = new HtmlToPdfDocument()
			{
				GlobalSettings = new GlobalSettings() {
					Margins = new MarginSettings(0,0,0,0)
				}
			};

			doc.Objects.Add(new ObjectSettings() {
				HtmlContent = html,
			});

			var pdf = converter.Convert(doc);
			return pdf;
		}
	}
}
