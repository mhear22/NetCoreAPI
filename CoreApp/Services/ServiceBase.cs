using dotapi.Repositories;

namespace dotapi.Services
{
	public class ServiceBase
	{
		public ServiceBase(IContext context)
		{
			this.Context = context;
		}
		internal IContext Context { get; set; }
	}
}