using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace dotapi.Tests.Actions
{
	public class ActionTestBase
	{
		private TestServer _server;
		public HttpClient _client;
		public ActionTestBase()
		{
			_server = new TestServer(new WebHostBuilder()
				.UseStartup<TestStartup>());
			_client = _server.CreateClient();
		}
	}
}