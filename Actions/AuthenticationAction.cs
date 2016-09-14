using dotapi.Actions;
using Microsoft.AspNetCore.Mvc;

namespace dotapi 
{
	public class AuthenticationAction : ActionBase
	{
		public AuthenticationAction()
		{
			AddAction(() => DoThing());
		}
		
		public IActionResult DoThing()
		{
			return Ok("abcd");
		} 
	}
	
}