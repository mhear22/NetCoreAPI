using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions
{
	public class ActionBase
	{
		private ICollection<Func<IActionResult>> _actions = new List<Func<IActionResult>>();
		protected HttpRequest Request { get; private set; }
		
		internal void AddAction(Func<IActionResult> action)
		{
			_actions.Add(action);
		}
		
		public IActionResult WithRequest(HttpRequest request)
		{
			Request = request;
			
			foreach(var action in _actions)
			{
				try{
					var response = action();
					if(response != null)
					{
						return response;
					}
				}
				catch (Exception ex){
					return Respond(ex.Message);
				}
			}
			return Respond("No Action returned a response");
		}
		
		internal IActionResult Ok(object payload = null)
		{
			return Respond(payload, HttpStatusCode.OK);
		}
		
		protected IActionResult Created(object payload = null)
		{
			return Respond(payload, HttpStatusCode.Created);
		}
		
		protected IActionResult BadRequest(object payload = null)
		{
			return Respond(payload, HttpStatusCode.BadRequest);
		}
		
		protected IActionResult Unauthorized(object payload = null)
		{
			return Respond(payload, HttpStatusCode.Unauthorized);
		}
		
		protected IActionResult NotFound(object payload = null)
		{
			return Respond(payload, HttpStatusCode.NotFound);
		}
		private IActionResult Respond(object payload, HttpStatusCode code = HttpStatusCode.InternalServerError)
		{
			var response = new JsonResult(payload);
			response.StatusCode = (int)code;
			return response;
		}
	}
}