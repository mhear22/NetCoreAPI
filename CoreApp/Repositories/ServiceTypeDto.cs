using CoreApp.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Repositories
{
	public class ServiceTypeDto : IRow
	{
		public string Id { get; set; }
		public string Name { get; set; }
		//Maybe have image for the service item, or most common change freq
	}
}
