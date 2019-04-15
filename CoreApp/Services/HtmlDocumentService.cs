using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CoreApp.Repositories;

namespace CoreApp.Services
{
	public interface IHtmlDocumentService
	{
		string GetStaticContent();
		string GetDocument(string Type);
		List<string> GetDocumentNames();
	}

	public class HtmlDocumentService : ServiceBase, IHtmlDocumentService
	{
		public HtmlDocumentService(IContext context)
			: base(context)
		{

		}

		private string Root
		{
			get
			{
				return Directory.GetCurrentDirectory();
			}
		}

		public string GetDocumentType(string Type)
		{
			var dir = Root + "/Forms/";
			return Directory.GetFiles(dir).Where(x => x.ToLower() == Type.ToLower()).FirstOrDefault();
		}

		public string GetDocument(string Type)
		{
			var dir = Root + $"/Forms/{GetDocumentType(Type)}/";
			var files = Directory.GetFiles(dir);

			var CSSList = files.Where(x => x.EndsWith(".css"));
			var HtmlList = files.Where(x => x.EndsWith(".html"));

			if (HtmlList.Count() > 1)
				throw new ArgumentException("Too many templates in folder");

			var css = CSSList.Select(x => File.ReadAllText(x)).Aggregate((x, y) => x + y);
			var html = File.ReadAllText(HtmlList.FirstOrDefault());


			return Regex.Replace(html, "<head>", $"<head><style>{css}</style>");
		}
		
		public string GetStaticContent()
		{
			var dir = Root + $"/StaticContent/Bootstrap/css/bootstrap.min.css";
			var css = File.ReadAllText(dir);
			return css;
		}

		public List<string> GetDocumentNames()
		{
			var dir = Root + $"/Forms/";
			var Folders = Directory.GetDirectories(dir);
			return Folders.Select(x=> x.Split('/').LastOrDefault()).ToList();
		}
	}
}
