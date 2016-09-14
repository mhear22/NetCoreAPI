using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using Xunit;

namespace dotapi.Tests
{
	public class ActionTestBase
	{
		internal HttpClient _client;
		internal TestServer _server;
		public ActionTestBase()
		{
			_server = new TestServer(new WebHostBuilder()
				.UseStartup<Startup>());
			_client = _server.CreateClient();
		}
		
		internal string Get(string Url, HttpStatusCode expectedCode = HttpStatusCode.OK)
		{
			var response = _client.GetAsync(Url).Result;
			
			Assert.True(response.StatusCode == expectedCode, "Status code was not expected");
			
			var result = response.Content.ReadAsStringAsync().Result;
			
			return result;
		}
		
		internal T Get<T>(string Url, HttpStatusCode expectedCode = HttpStatusCode.OK)
		{
			var model = JsonConvert.DeserializeObject<T>(Get(Url, expectedCode));
			
			Assert.True(model != null);
			
			return model;
		}
	}
}