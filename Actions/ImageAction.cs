using dotapi.Actions.User;
using dotapi.Services;

namespace dotapi.Actions
{
	public class ImageAction: UserAction
	{
		private IImageService imageService;
		public ImageAction(IImageService imageService, IUserService userService, IAuthenticationService auth, ICurrentUserService current)
			: base(userService, auth, current)
		{
			this.imageService = imageService;
		}
	}
}