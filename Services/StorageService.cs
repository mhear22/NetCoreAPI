using dotapi.Repositories;

namespace dotapi.Services
{
	public interface IStorageService
	{
		
	}
	
	public class StorageService : ServiceBase, IStorageService
	{
		public StorageService(IContext context) : base(context) { }
	}
}