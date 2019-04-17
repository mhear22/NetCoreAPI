using CoreApp.Models.Storage;
using CoreApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Services
{
	public interface IImageService
	{
		StorageModel UploadFile(IFormFile file);
		IActionResult GetFile(string Id);
	}

	public class ImageService: ServiceBase, IImageService
	{
		private IStorageService storageService;
		public ImageService(IStorageService storageService, IContext context) 
			: base(context)
		{
			this.storageService = storageService;
		}
		
		public StorageModel UploadFile(IFormFile file)
		{
			var stream = file.OpenReadStream();

			if (stream.Length > int.MaxValue)
			{
				throw new ArgumentException("File Too Large");
			}
			var Model = new StorageModel();
			Model.Filename = file.FileName;
			Model.DateCreated = DateTime.UtcNow;
			using (BinaryReader br = new BinaryReader(stream))
				Model.data = br.ReadBytes(Convert.ToInt32(stream.Length));

			return storageService.Create(Model);
		}

		public IActionResult GetFile(string Id)
		{
			var result = storageService.Get(Id);
			var x = new FileContentResult(result.data, "image/png");
			return x;
		}
	}
}
