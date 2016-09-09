using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using dotapi.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions
{
	public class ActionBase
	{
		private ICollection<Func<IActionResult>> _actions = new List<Func<IActionResult>>();
		private HttpRequest Request;
		
		public void AddAction(Func<IActionResult> action)
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
		
		internal IActionResult Ok(object payload = null)
		{
			return Respond(payload, HttpStatusCode.OK);
		}
		private IActionResult Respond(object payload, HttpStatusCode code = HttpStatusCode.InternalServerError)
		{
			var response = new JsonResult(payload);
			response.StatusCode = (int)code;
			return response;
		}
	}
}