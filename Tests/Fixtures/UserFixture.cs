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
		
		public CreateUserModel Generate()
		{
			var model = new CreateUserModel()
			{
				Username = RandomString(),
				Email = RandomString() + "@" + RandomString(),
				Password = RandomString()
			};
			
			var request = Post("/users", model);
			
			Assert.True(request.StatusCode == HttpStatusCode.OK);
			
			var responseModel = JsonConvert.DeserializeObject<UserModel>(
				request.Content.ReadAsStringAsync().Result
			);
			
			Assert.True(responseModel.Email == model.Email);
			Assert.True(responseModel.Username == model.Username);
			
			return model; 
		}
	}
}