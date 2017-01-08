using System.Collections.Generic;
using System.IO;
using dotapi.Controllers;
using dotapi.Services;
using dotapi.Services.Storage;
using Microsoft.AspNetCore.Http;
using Moq;
using Xunit;

namespace dotapi.Tests.Controllers
{
	public class ImageControllerTests : BaseControllerMock<ImageController>
	{
		[Fact]
		public void ImageController_WithFile_CreatesImage()
		{
			var file = new Mock<IFormFile>();
			var str = "pretend file";
			var ms = new MemoryStream();
			var sw = new StreamWriter(ms);
			sw.Write(str);
			sw.Flush();
			ms.Position = 0;
			file.Setup(x=>x.OpenReadStream()).Returns(ms);
			
			var result = Controller.UploadImage(file.Object);
		}
	}
}