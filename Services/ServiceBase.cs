using dotapi.Repositories;

namespace dotapi.Services
{
	public class ServiceBase
	{
		public ServiceBase(IDatabaseContext context)
		{
			this.Context = context;
		}
		internal IDatabaseContext Context { get; set; }
	}
}