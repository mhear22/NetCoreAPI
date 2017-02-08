using Microsoft.AspNetCore.Mvc;
using dotapi.Repositories;
using dotapi.Services;
using Microsoft.AspNetCore.Http;
using dotapi.Actions;

namespace dotapi.Controllers
{
	public class ImageController : ApiController
	{
		private IImageAction imageAction;
		public ImageController(IContext context, IImageAction image) 
			: base(context)
		{
			this.imageAction = image;
		}
		
		[Route("i/{ImageId}")]
		[HttpGet]
		public IActionResult GetImage(string ImageId)
		{
			return imageAction.GetFile(ImageId).WithRequest(Request);
		}
		
		[Route("i/{ImageId}/detail")]
		[HttpGet]
		public IActionResult GetImageDetails(string ImageId)
		{
			return Ok();
		}
		
		[Route("i")]
		[HttpPost]
		public IActionResult UploadImage(IFormFile file)
		{
			return imageAction.UploadFile(file).WithRequest(Request);
		}
		
		[Route("i/{ImageId}")]
		[HttpDelete]
		public IActionResult DeleteImage()
		{
			return Ok();
		}
	}
}