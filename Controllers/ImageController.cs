using dotapi.Actions.User;
using dotapi.Actions.Session;
using dotapi.Actions.CurrentUser;
using dotapi.Models.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Controllers
{
	public class ImageController : Controller
	{
		[Route("i/{ImageId}")]
		[HttpGet]
		public IActionResult GetImage(string ImageId)
		{
			return Ok();
		}
		
		[Route("i/{ImageId}/detail")]
		[HttpGet]
		public IActionResult GetImageDetails(string ImageId)
		{
			return Ok();
		}
		
		[Route("i")]
		[HttpPost]
		public IActionResult UploadImage()
		{
			return Created("","");
		}
		
		[Route("i/{ImageId}")]
		[HttpDelete]
		public IActionResult DeleteImage()
		{
			return Ok();
		}
	}
}