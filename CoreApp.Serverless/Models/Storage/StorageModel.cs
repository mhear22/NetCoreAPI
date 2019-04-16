using System;
using CoreApp.Models.Generic;

namespace CoreApp.Models.Storage
{
	public class StorageModel : FileModel
	{
		public string Id;
		public string Path;
		public DateTime DateCreated;
	}
}