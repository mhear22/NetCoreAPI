using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models.Repositories
{
	public class PostDto : IRow
	{
		public string Id { get; set; }
		public string PostTypeId { get; set; }
	}
}
