using System.Collections.Generic;

namespace dotapi.Models.Generic
{
	public class Page<T>
	{
		public IList<T> Items;
		public int Count;
	}
}