using CoreApp.Repositories;

namespace CoreApp.Services
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