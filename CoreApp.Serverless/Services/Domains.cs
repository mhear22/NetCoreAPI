using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Services
{
	public class Domains
	{
#if DEBUG
		public static string Api = "http://localhost:5000";
		public static string Route = "http://localhost:4200";
#else
		public static string Api = "https://api.mechie.net";
		public static string Route = "https://www.mechie.net";
#endif
	}
}
