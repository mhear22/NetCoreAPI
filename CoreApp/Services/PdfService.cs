using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;

namespace CoreApp.Services
{
	public interface IPdfService
	{
		byte[] GeneratePDF(string ReportType, object Data);
	}

	public class PdfService : ServiceBase, IPdfService
	{
		private IHtmlService htmlService;
		public PdfService(
			IContext context,
			IHtmlService htmlService
		) : base(context)
		{
			this.htmlService = htmlService;
		}

		public byte[] GeneratePDF(string ReportType, object Data)
		{
			var html = this.htmlService.GenerateHtml(ReportType, Data);




			throw new NotImplementedException();
		}
	}
}
