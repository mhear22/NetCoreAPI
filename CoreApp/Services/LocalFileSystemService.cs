using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Repositories;

namespace CoreApp.Services
{
	public interface ILocalFileSystemService
	{
		string GetLocalDir();
	}

	public class LocalFileSystemService : ServiceBase, ILocalFileSystemService
	{
		public LocalFileSystemService(IContext context) 
			: base(context)
		{
		}

		public string GetLocalDir()
		{
			return Directory.GetCurrentDirectory();
		}
	}
}
