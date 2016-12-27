using dotapi.Controllers;
using dotapi.Services;
using dotapi.Services.Storage;
using Xunit;

namespace dotapi.Tests.Controllers
{
	public class ImageControllerTests : BaseControllerMock<ImageController>
	{
		public ImageControllerTests()
			: base((Context) => 
				new ImageController(Context, new ImageService(Context,new SQLStorageService(Context)))
			)
		{
			
		}
		
		[Fact]
		public void Test()
		{
			Assert.True(true);
		}
	}
}