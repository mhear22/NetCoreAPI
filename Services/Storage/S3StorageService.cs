using System;
using Amazon.S3;
using dotapi.Models.Generic;
using dotapi.Models.Storage;

namespace dotapi.Services.Storage
{
    public class S3StorageService : IStorageService
    {
		public S3StorageService()
		{
			throw new NotImplementedException();
		}
		
        public StorageModel Create(StorageModel model)
        {
			throw new NotImplementedException();
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