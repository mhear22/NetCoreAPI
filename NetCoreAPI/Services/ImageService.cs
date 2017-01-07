using dotapi.Repositories;
using dotapi.Services.Storage;

namespace dotapi.Services
{
	public interface IImageService
	{
		
	}
	
	public class ImageService : ServiceBase, IImageService
	{
		private IStorageService storageService;
		public ImageService(IContext context, IStorageService storage) 
			: base(context)
		{
			this.storageService = storage;
		}
	}
}