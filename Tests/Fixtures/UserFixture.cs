using System;
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
		
		public HttpResponseMessage CreateUser(CreateUserModel model)
		{
			return Post("/users", model);
		}
		
		public HttpResponseMessage GetUserRequest(string UserId)
		{
			return Get("users/" + UserId);
		}
		
		public CreateUserModel Generate(CreateUserModel model)
		{
			var request = CreateUser(model);
			
			if(request.StatusCode != HttpStatusCode.Created)
				return null;
			
			var responseModel = JsonConvert.DeserializeObject<UserModel>(
				request.Content.ReadAsStringAsync().Result
			);
			
			Assert.True(responseModel.Email == model.Email);
			Assert.True(responseModel.Username == model.Username);
			
			return model; 
		}
		public CreateUserModel Generate()
		{
			var model = new CreateUserModel()
			{
				Username = RandomString(),
				Email = RandomString() + "@" + RandomString(),
				Password = RandomString()
			};
			
			return Generate(model);
		}
		
		public UserModel GetUser(string UserId)
		{
			var request = GetUserRequest(UserId);
			
			if(request.StatusCode != HttpStatusCode.OK)
				return null;
			var responseModel = JsonConvert.DeserializeObject<UserModel>(
				request.Content.ReadAsStringAsync().Result
			);
			
			return responseModel;
		}
	}
}