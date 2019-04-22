using CoreApp.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CoreAppTests.Mocks
{
	class MockLocalFileSystemService : ILocalFileSystemService
	{
		public string GetLocalDir()
		{
			var dir = Directory.GetCurrentDirectory();
			var result = dir.Replace("\\CoreAppTests\\", "\\CoreApp\\");
			return result;
		}
	}
}
