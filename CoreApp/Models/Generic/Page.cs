using System.Collections.Generic;

namespace CoreApp.Models.Generic
{
	public class Page<T>
	{
		public IList<T> Items;
		public int Count;
	}
}