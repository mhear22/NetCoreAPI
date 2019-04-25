using System.Net;
using System.Net.Http;
using CoreApp.Models.Authentication;
using Newtonsoft.Json;
using Xunit;

namespace CoreAppTests.Fixtures
{
	public class UserFixture : BaseFixture
	{
		public UserFixture(HttpClient client) 
			: base(client)
		{ }
		
		public HttpResponseMessage CreateUserRequest(CreateUserModel model)
		{
			return Post("/users", model);
		}
		public HttpResponseMessage GetSessionTokenRequest(LoginModel model)
		{
			return Post("/sessions", model);
		} 
		public HttpResponseMessage GetUserRequest(string UserId)
		{
			return Get("/users/" + UserId);
		}

		private HttpResponseMessage VerifyUser(string UserId)
		{
			return Get($"/verify/{UserId}");
		}

		public HttpResponseMessage UpdateUserRequest(string UserId, UserModel model)
		{
			var url = "/users/" + UserId;
			return Put(url, model);
		}
		
		public UserModel Update(string UserId, UserModel model)
		{
			var request = UpdateUserRequest(UserId, model);
			var result = JsonConvert.DeserializeObject<UserModel>(
				request.Content.ReadAsStringAsync().Result
			);
			
			return result;
		}
		public CreateUserModel Generate(CreateUserModel model)
		{
			var request = CreateUserRequest(model);
			
			if(request.StatusCode != HttpStatusCode.OK)
				return null;
			
			var responseModel = JsonConvert.DeserializeObject<UserModel>(
				request.Content.ReadAsStringAsync().Result
			);

			VerifyUser(responseModel.Id);
			
			Assert.True(responseModel.EmailAddress == model.EmailAddress);
			Assert.True(responseModel.Username == model.Username);
			
			model.Id = responseModel.Id;
			
			return model; 
		}

		public CreateUserModel Generate()
		{
			var model = new CreateUserModel()
			{
				Username = RandomString(),
				EmailAddress = RandomString() + "@" + RandomString(),
				Password = RandomString(),
			};
			
			return Generate(model);
		}
		public UserModel GetUser(string UserId)
		{
			var request = GetUserRequest(UserId);
			
			if(request.StatusCode != HttpStatusCode.OK)
				return null;
			return JsonConvert.DeserializeObject<UserModel>(
				request.Content.ReadAsStringAsync().Result
			);
		}
		public string GetSessionToken(LoginModel model)
		{
			var request = GetSessionTokenRequest(model);
			
			if(request.StatusCode != HttpStatusCode.OK)
				return null;

			var data = request.Content.ReadAsStringAsync().Result;
			return data;
		}
	}
}