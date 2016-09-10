using System;
using System.Collections.Generic;

namespace dotapi.Repositories.Helpers
{
	public class DtoReader<T>
	{
		private Dictionary<string, Type> Columns = new Dictionary<string, Type>();
		
		public DtoReader()
		{
			throw new NotImplementedException();
		}
		
		private void ReadClassAttributes()
		{
			throw new NotImplementedException();
		}
	}
}