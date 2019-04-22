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
		string GetDocument(string Type);
		List<string> GetDocumentNames();
	}

	public class HtmlDocumentService : ServiceBase, IHtmlDocumentService
	{
		private ILocalFileSystemService localFileSystemService;
		public HtmlDocumentService(
			IContext context,
			ILocalFileSystemService localFileSystemService
		) : base(context)
		{
			this.localFileSystemService = localFileSystemService;
		}

		private string Root
		{
			get
			{
				return this.localFileSystemService.GetLocalDir();
			}
		}

		private string GetDocumentType(string Type)
		{
			var dir = Root + "/Forms/";
			var files = Directory.GetDirectories(dir).Select(x=>x.Split("/").Last());
			var filenames = files.Where(x => x.ToLower() == Type.ToLower());
			return filenames.FirstOrDefault();
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
		
		public List<string> GetDocumentNames()
		{
			var dir = Root + $"/Forms/";
			var Folders = Directory.GetDirectories(dir);
			return Folders.Select(x=> x.Split('/').LastOrDefault()).ToList();
		}
	}
}
