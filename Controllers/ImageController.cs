using Microsoft.AspNetCore.Mvc;
using dotapi.Repositories;
using dotapi.Services;
using Microsoft.AspNetCore.Http;

namespace dotapi.Controllers
{
	public class ImageController : ApiController
	{
		private IImageService imageService;
		public ImageController(IContext context, IImageService image) 
			: base(context)
		{
			this.imageService = image;
		}
		
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
		public IActionResult UploadImage(IFormFile file)
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