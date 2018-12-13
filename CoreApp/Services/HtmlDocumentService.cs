﻿using System;
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

		public string GetDocument(string Type)
		{
			var dir = Root + $"/Forms/{Type}/";
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
			return Folders.ToList();
		}
	}
}