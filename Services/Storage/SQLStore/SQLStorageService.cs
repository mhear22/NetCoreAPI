using System;
using dotapi.Models.Generic;
using dotapi.Models.Storage;
using dotapi.Repositories;

namespace dotapi.Services.Storage.SQLStore
{
	public class SQLStorageService : ServiceBase, IStorageService
	{
		public SQLStorageService(IContext context) : base(context)
		{ }

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