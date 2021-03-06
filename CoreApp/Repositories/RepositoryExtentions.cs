using System.Linq;
using CoreApp.Models.Generic;

namespace CoreApp.Repositories
{
	public static class RepositoryExtentions
	{
		public static Page<T> ToPage<T>(this IOrderedQueryable<T> list, IPageQuery query)
		{
			var count = list.Count();
			var items = list.Skip(query.Skip).Take(query.Take).ToList();
			return new Page<T>()
			{
				Items = items,
				Count = count
			};
		}
	}
}