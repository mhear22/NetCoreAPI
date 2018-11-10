using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;

namespace CoreApp.Services
{
	public interface IHtmlService
	{
		string GenerateHtml(string ReportType, object Data = null);
	}

	public class HtmlService : ServiceBase, IHtmlService
	{
		public HtmlService(IContext context) : base(context)
		{
		}

		public string GenerateHtml(string ReportType, object Data = null)
		{
			if(ReportType.ToLower() == "test")
			{
				return @"
<html>
<body>
<h1>Hello World</h1>
</body>
</html>
";
			}

			throw new ArgumentException($"Could not find a report called {ReportType}");
		}
	}
}
