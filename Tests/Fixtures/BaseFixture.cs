using System;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace dotapi.Tests.Fixtures
{
	public class BaseFixture
	{
		internal HttpClient _client;
		public BaseFixture(HttpClient client)
		{
			this._client = client;
		}
		
		private static int counter = 0; 
		internal static string RandomString()
		{
			var bytes = DateTime.Now.AddDays(counter).Ticks.ToString()
				.Select(x=>Convert.ToByte(x))
				.ToArray();
			return Convert.ToBase64String(MD5.Create().ComputeHash(bytes));
		}
		
		internal HttpResponseMessage Post(string url,object data = null)
		{
			var serialised = JsonConvert.SerializeObject(data);
			
			HttpContent content = new StringContent(serialised,Encoding.UTF8, "application/json");
			
			return _client.PostAsync(url, content).Result;
		}
		
		internal HttpResponseMessage Get(string url)
		{
			return _client.GetAsync(url).Result;
		}
		
		internal HttpResponseMessage Put(string url, object data = null)
		{
			HttpContent content = new StringContent(JsonConvert.SerializeObject(data),Encoding.UTF8,"application,json");
			return _client.PutAsync(url, content).Result;
		}
		
		internal HttpResponseMessage Delete(string url)
		{
			return _client.DeleteAsync(url).Result;
		}
	}
}