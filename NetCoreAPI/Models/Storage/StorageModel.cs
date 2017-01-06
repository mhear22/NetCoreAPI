using System;
using dotapi.Models.Generic;

namespace dotapi.Models.Storage
{
	public class StorageModel : FileModel
	{
		public string Id;
		public string Path;
		public DateTime DateCreated;
	}
}