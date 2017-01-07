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
}