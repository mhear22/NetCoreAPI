using System;
using dotapi.Controllers;
using dotapi.Models.Authentication;
using dotapi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions.Proto
{
	public class BaseAction
	{
		protected HttpRequest Request;
		public BaseAction(IContext Context) { }
		
		public IActionResult WithRequest(HttpRequest request)
		{
			Request = request;
			throw new NotImplementedException();
		}
	}
	
	public class UserAction: BaseAction 
	{
		public UserAction(IContext context)
			: base(context) 
		{ }
		
		public UserAction CreateUser(CreateUserModel model)
		{
			return this;
		}
	}
	
	public class MockController : ApiController
	{
		private UserAction user;
		public MockController(IContext context) 
			: base(context) 
		{
			user = new UserAction(context);
		}
		
		public IActionResult Func(CreateUserModel model)
		{
			return user.CreateUser(model).WithRequest(Request);
		}
	}
}