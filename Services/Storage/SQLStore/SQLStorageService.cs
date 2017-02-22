using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Amazon.S3;
using Amazon.S3.Model;
using dotapi.Models.Generic;
using dotapi.Models.Repositories;
using dotapi.Models.Storage;
using dotapi.Repositories;

namespace dotapi.Services.Storage.SQLStore
{
	public class SQLStorageService : ServiceBase, IStorageService
	{
		private IRepository<FileDto> fileRepo;
		private IRepository<FilePieceDto> piece;
		private IRepository<FilePiecesDto> pieces;
		private IAmazonS3 s3Client;
		public SQLStorageService(IContext context,
			IRepository<FileDto> fileRepo, 
			IRepository<FilePieceDto> piece, 
			IRepository<FilePiecesDto> pieces,
			IAmazonS3 s3Client) 
			: base(context)
		{
			this.s3Client = s3Client;
			this.fileRepo = fileRepo;
			this.piece = piece;
			this.pieces = pieces;
		}
		private string DefaultBucket = "storage-sydney-a";
		public StorageModel Create(StorageModel model)
		{
			var result = fileRepo.Create(new FileDto(){
				Id = Guid.NewGuid().ToString(),
				Length = model.data.Length,
				Filename = model.Filename
			});
			
			var data = model.data.ToList();
			List<byte[]> items = new List<byte[]>();
			var chunkSize = 1000000;
			//var chunkSize = 254;
			while(data.Any())
			{
				items.Add(data.Take(chunkSize).ToArray());
				data = data.Skip(chunkSize).ToList();
			}
			
			var dataPieces = items.Select(x=>{
				var hashbytes = System.Security.Cryptography.SHA1.Create().ComputeHash(x);
				var hashString = "";
				var hash = hashbytes.Select(z=> hashString += String.Format("{0:x2}", z)).ToArray();
				
				return new FilePieceModel(){
					Id = Guid.NewGuid().ToString(),
					Length = x.Length,
					Hash = hashString,
					Bytes = x
				};
			})
			.ToList()
			.Select(x=> {
				var initResult = s3Client.InitiateMultipartUploadAsync(DefaultBucket, x.Hash).Result;
				var requ = new UploadPartRequest(){
					InputStream = new MemoryStream(x.Bytes),
					BucketName = DefaultBucket,
					Key = x.Hash
				};
				try{
					var response = s3Client.UploadPartAsync(requ).Result;
					if(true) { }
				}
				catch{}
				s3Client.CompleteMultipartUploadAsync(new CompleteMultipartUploadRequest(){
					Key = x.Hash,
					BucketName = DefaultBucket
				});
				return piece.Create(new FilePieceDto(){
					Id = x.Id,
					Length = x.Length,
					Hash = x.Hash
				});
			})
			.ToList();
			int index = 0;
			dataPieces.Select(x=> {
				var connect = new FilePiecesDto() {
					Id = Guid.NewGuid().ToString(),
					FilePieceId = x.Id,
					FileId = result.Id,
					PieceNumber = index++ 
				};
				return pieces.Create(connect);
			}).ToList();
			model.data = null;
			model.Id = result.Id;
			return model;
		}

		public void Delete(string Id)
		{
			throw new NotImplementedException();
		}

		public StorageModel Get(string Id)
		{
			var dto = fileRepo.Get(Id);
			if(dto == null)
				throw new KeyNotFoundException($"Could not find {Id}");
			var model = new StorageModel();
			var filePieces = pieces.Where(x=>x.FileId == dto.Id).ToList().OrderBy(x=>x.PieceNumber).Select(x=>x.FilePieceId);
			var dataItems = piece.Where(x=>filePieces.Contains(x.Id)).ToList();
			var fileData = filePieces
				.Select(x=> dataItems.FirstOrDefault(z=>z.Id == x))
				.Select(x=>x.Hash)
				.ToList()
				.Select(x=>{
					var result = s3Client.GetObjectAsync(DefaultBucket, x).Result;
					byte[] part;
					using(BinaryReader br = new BinaryReader(result.ResponseStream))
						part = br.ReadBytes(Convert.ToInt32(result.ResponseStream.Length));
					return part;
				}).ToList();
			model.data = fileData.SelectMany(x=>x).ToArray();
			model.Filename = dto.Filename;
			model.Id = dto.Id;
			return model;
		}

		public Page<StorageItem> Search(StorageQuery query)
		{
			throw new NotImplementedException();
		}
	}
}