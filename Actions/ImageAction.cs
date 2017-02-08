using dotapi.Actions.User;
using dotapi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions
{
	public interface IImageAction
	{
		ImageAction UploadFile(IFormFile file);
	}
	
	public class ImageAction: UserAction, IImageAction
	{
		private IImageService imageService;
		public ImageAction(IImageService imageService, IUserService userService, IAuthenticationService auth, ICurrentUserService current)
			: base(userService, auth, current)
		{
			this.imageService = imageService;
		}
		
		public ImageAction UploadFile(IFormFile file)
		{
			AddAction(() => Upload(file));
			return this;
		}
		
		private IActionResult Upload(IFormFile file)
		{
			var stream = file.OpenReadStream();
			if(true){
				int i = 0;
				i++;
			}
			return Ok();
		}
	}
}