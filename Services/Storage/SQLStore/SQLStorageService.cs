using System;
using System.Collections.Generic;
using System.Linq;
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
		 
		public SQLStorageService(IContext context, 
			IRepository<FileDto> fileRepo, 
			IRepository<FilePieceDto> piece, 
			IRepository<FilePiecesDto> pieces) 
			: base(context)
		{
			this.fileRepo = fileRepo;
			this.piece = piece;
			this.pieces = pieces;
		}

		public StorageModel Create(StorageModel model)
		{
			var result = fileRepo.Create(new FileDto(){
				Id = Guid.NewGuid().ToString(),
				Length = model.data.Length,
				Filename = model.Filename
			});
			
			
			var data = model.data.ToList();
			List<byte[]> items = new List<byte[]>();
			var chunkSize = 10^6;
			while(data.Any())
			{
				items.Add(data.Take(chunkSize).ToArray());
				data = data.Skip(chunkSize).ToList();
			}
			
			var dataPieces = items.Select(x=>{
				var hashbytes = System.Security.Cryptography.SHA1.Create().ComputeHash(x);
				var hashString = "";
				var hash = hashbytes.Select(z=> hashString += String.Format("{0:x2}", z)).ToArray();
				
				return new FilePieceDto(){
					Id = Guid.NewGuid().ToString(),
					Length = x.Length,
					Hash = hashString,
					Bytes = x
				};
			}).Select(x=> piece.Create(x)).ToList();
			
			int index = 0;
			dataPieces.Select(x=> {
				var connect = new FilePiecesDto() {
					Id = Guid.NewGuid().ToString(),
					FilePieceId = x.Id,
					FileId = result.Id,
					PieceNumber = index++ 
				};
				return pieces.Create(connect);
			});
			
			
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
			
			var filePieces = pieces.Where(x=>x.FileId == dto.Id).ToList().OrderBy(x=>x.PieceNumber).Select(x=>x.FilePieceId);
			
			//var dataPieces = piece.Where(x=>)
			
			throw new NotImplementedException();
		}

		public Page<StorageItem> Search(StorageQuery query)
		{
			throw new NotImplementedException();
		}
	}
}