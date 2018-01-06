using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace CoreApp.Tests.Actions
{
	public class TestBase
	{
		private TestServer _server;
		public HttpClient _client;
		public TestBase()
		{
			var webhost = new WebHostBuilder().UseStartup<TestStartup>();
			_server = new TestServer(webhost);
			_client = _server.CreateClient();
		}
	}
}