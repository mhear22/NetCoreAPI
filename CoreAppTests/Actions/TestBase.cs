using System.Net.Http;
using CoreApp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace CoreAppTests.Actions
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