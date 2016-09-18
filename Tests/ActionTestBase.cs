using System;
using System.Net;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using Xunit;

namespace dotapi.Tests
{
	public class ActionTestBase
	{
		private TestServer _server;
		private HttpClient _client;
		public ActionTestBase()
		{
			_server = new TestServer(new WebHostBuilder()
				.UseStartup<Startup>());
			_client = _server.CreateClient();
		}
		
		internal string Post(string Url, object Payload = null, HttpStatusCode expectedCode = HttpStatusCode.OK)
		{
			HttpContent content = new StringContent(JsonConvert.SerializeObject(Payload),Encoding.UTF8, "application/json");
			var request = _client.PostAsync(Url,content).Result;
			Assert.True(request.StatusCode == expectedCode, "Status code was not expected");
			return request.Content.ReadAsStringAsync().Result;
		}
		
		internal T Post<T>(string Url, object Payload = null, HttpStatusCode expectedCode = HttpStatusCode.OK)
		{
			return JsonConvert.DeserializeObject<T>(Post(Url, Payload, expectedCode));
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
			var data = Get(Url, expectedCode);
			if(data == null)
				return default(T);
			return JsonConvert.DeserializeObject<T>(data);
		}
	}
}