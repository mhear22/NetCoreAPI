using System;
using System.IO;
using dotapi.Actions.User;
using dotapi.Models.Storage;
using dotapi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotapi.Actions
{
	public interface IImageAction
	{
		ImageAction UploadFile(IFormFile file);
		ImageAction GetFile(string Id);
	}
	
	public class ImageAction: UserAction, IImageAction
	{
		private IStorageService storageService;
		public ImageAction(IStorageService storageService, IUserService userService, IAuthenticationService auth, ICurrentUserService current)
			: base(userService, auth, current)
		{
			this.storageService = storageService;
		}
		
		public ImageAction UploadFile(IFormFile file)
		{
			AddAction(() => Upload(file));
			return this;
		}
		
		public ImageAction GetFile(string FileId)
		{
			AddAction(() => GetFileData(FileId));
			return this;
		}
		
		private IActionResult Upload(IFormFile file)
		{
			var stream = file.OpenReadStream();
			
			if(stream.Length > int.MaxValue) {
				return BadRequest("File Too Large");
			}
			var Model = new StorageModel();
			Model.Filename = file.FileName;
			Model.DateCreated = DateTime.UtcNow;
			using(BinaryReader br = new BinaryReader(stream))
				Model.data = br.ReadBytes(Convert.ToInt32(stream.Length));
			
			return Ok(storageService.Create(Model));
		}
		
		private IActionResult GetFileData(string Id)
		{
			var result = storageService.Get(Id);
			var x = new FileContentResult(result.data, "image/png");
			return x;
		}
	}
}