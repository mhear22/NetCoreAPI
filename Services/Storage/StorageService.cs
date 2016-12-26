using System;
using System.IO;
using dotapi.Models.Generic;
using dotapi.Models.Storage;
using dotapi.Repositories;

namespace dotapi.Services.Storage
{
	public interface IStorageService
	{
		StorageModel Get(string Id);
		Page<StorageItem> Search(StorageQuery query);
		void Delete(string Id);
		StorageModel Create(StorageModel model);
	}
	
	public class FileStorageService : ServiceBase, IStorageService
	{
		private string Root;
		public FileStorageService(IContext context) 
			: base(context)
		{
			Root = Path.GetTempPath();
		}

        public StorageModel Create(StorageModel model)
        {
			model.DateCreated = DateTime.Now;
			var path = Path.Combine(Root, model.Path);
			Directory.CreateDirectory(path);
			File.WriteAllBytes(path, model.data);
			return model;
        }

        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public StorageModel Get(string Id)
        {
            throw new NotImplementedException();
        }

        public Page<StorageItem> Search(StorageQuery query)
        {
            throw new NotImplementedException();
        }
    }
}