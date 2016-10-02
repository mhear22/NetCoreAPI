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
		private HttpRequest Request;
		
		internal void AddAction(Func<IActionResult> action)
		{
			_actions.Add(action);
		}
		
		public IActionResult WithRequest(HttpRequest request)
		{
			Request = request;
			
			foreach(var action in _actions)
			{
				var response = action();
				if(response != null)
				{
					return response;
				}
			}
			return Respond("No Action returned a response");
		}
		
		internal T S<T>() {return GetService<T>(); }
		internal T GetService<T>()
		{
			var _service = Request.HttpContext.RequestServices.GetService(typeof(T));
			if(_service==null)
			{
				return default(T);
			}
			return (T)_service;
		}
		
		internal IActionResult Ok(object payload = null)
		{
			return Respond(payload, HttpStatusCode.OK);
		}
		
		internal IActionResult Created(object payload = null)
		{
			return Respond(payload, HttpStatusCode.Created);
		}
		
		internal IActionResult BadRequest(object payload = null)
		{
			return Respond(payload, HttpStatusCode.BadRequest);
		}
		
		internal IActionResult NotFound(object payload = null)
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