using dotapi.Models.Storage;
using dotapi.Repositories;
using dotapi.Services.Storage;
using dotapi.Services.Storage.SQLStore;
using dotapi.Models.Repositories;
using Xunit;

namespace dotapi.Tests.Services
{
    public class FileStorageServiceTests : ServiceTestBase<SQLStorageService>
	{
		public FileStorageServiceTests()
			: base((context) => 
				new SQLStorageService(
					context, 
					new Repository<FileDto>(context),
					new Repository<FilePieceDto>(context),
					new Repository<FilePiecesDto>(context)
				)
			)
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
		
		[Fact]
		public void FileStorageService_WithModel_Creates()
		{
			var result = Service.Create(model);
		}
		
		[Fact]
		public void FileStorageService_WithModel_Gets()
		{
			var Id = Service.Create(model);
			
			var result = Service.Get(Id.Id);
			
			Assert.True(result.data == model.data);
		}
	}
}