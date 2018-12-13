using Microsoft.AspNetCore.Mvc;
using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.AspNetCore.Http;
using CoreApp.Actions;

namespace CoreApp.Controllers
{
	public class ImageController : ApiController
	{
		private IImageService imageService;
		public ImageController(IContext context, IImageService imageService)
			: base(context)
		{
			this.imageService = imageService;
		}
		
		[Route("i/{ImageId}")]
		[HttpGet]
		public IActionResult GetImage(string ImageId) =>
			ReturnResult(() => this.imageService.GetFile(ImageId));
		
		[Route("i/{ImageId}/detail")]
		[HttpGet]
		public IActionResult GetImageDetails(string ImageId) =>
			ReturnResult(() => {});
		
		[Route("i")]
		[HttpPost]
		public IActionResult UploadImage(IFormFile file) =>
			ReturnResult(() => imageService.UploadFile(file));
		
		[Route("i/{ImageId}")]
		[HttpDelete]
		public IActionResult DeleteImage() => ReturnResult(() => {}, 500);
	}
}