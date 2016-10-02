using System;
using System.Net;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using Xunit;

namespace dotapi.Tests.Actions
{
	public class ActionTestBase
	{
		private TestServer _server;
		public HttpClient _client;
		public ActionTestBase()
		{
			_server = new TestServer(new WebHostBuilder()
				.UseStartup<Startup>());
			_client = _server.CreateClient();
		}
	}
}