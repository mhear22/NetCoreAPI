using dotapi.Models.Storage;
using dotapi.Services.Storage;
using Xunit;

namespace dotapi.Tests.Services
{
    public class FileStorageServiceTests : ServiceTestBase<SQLStorageService>
	{
		public FileStorageServiceTests()
			: base((Context) => new SQLStorageService(Context))
		{ }
			
		private StorageModel model = new StorageModel()
		{
			data = new byte[]
			{
				0,1,7,0
			},
			Filename = "abcd.txt",
			Path = "test/"
		};
		
		//[Fact]
		public void FileStorageService_WithModel_CreatesInDir()
		{
			var result = Service.Create(model);
		}
	}
}