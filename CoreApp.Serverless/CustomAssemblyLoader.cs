﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading.Tasks;

namespace CoreApp
{
	public class CustomAssemblyLoader : AssemblyLoadContext
	{
		public IntPtr LoadUnmanagedLibrary(string absolutePath)
		{
			return LoadUnmanagedDll(absolutePath);
		}
		protected override IntPtr LoadUnmanagedDll(String unmanagedDllName)
		{
			return LoadUnmanagedDllFromPath(unmanagedDllName);
		}

		protected override Assembly Load(AssemblyName assemblyName)
		{
			throw new NotImplementedException();
		}
	}
}
