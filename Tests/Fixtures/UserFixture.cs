using System.Net;
using System.Net.Http;
using dotapi.Models.Authentication;
using Newtonsoft.Json;
using Xunit;

namespace dotapi.Tests.Fixtures
{
	public class UserFixture : BaseFixture
	{
		public UserFixture(HttpClient client) 
			: base(client)
		{ }
		
		public UserModel Generate()
		{
			var model = new CreateUserModel()
			{
				Username = RandomString(),
				Email = RandomString() + "@" + RandomString(),
				Password = RandomString()
			};
			
			var request = Post("/users", model);
			
			Assert.True(request.StatusCode == HttpStatusCode.OK);
			
			return JsonConvert.DeserializeObject<UserModel>(
				request.Content.ReadAsStringAsync().Result
			);
		}
	}
}