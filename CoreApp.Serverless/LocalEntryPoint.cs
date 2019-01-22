using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CoreApp.Serverless
{
	/// <summary>
	/// The Main function can be used to run the ASP.NET Core application locally using the Kestrel webserver.
	/// </summary>
	public class LocalEntryPoint
	{
		public static void Main(string[] args)
		{
			BuildWebHost(args).Run();
		}

		public static IWebHost BuildWebHost(string[] args) =>
			new WebHostBuilder()
				.UseKestrel()
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseUrls(new string[]{
					"http://0.0.0.0:5000"
				})
				.UseIISIntegration()
				.UseStartup<Startup>()
				.UseApplicationInsights()
				.Build();
	}
}
