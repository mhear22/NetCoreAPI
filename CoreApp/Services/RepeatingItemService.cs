using CoreApp.Repositories;

namespace CoreApp.Services
{
	public interface IRepeatingItemService
	{
		void AddRepeatingItem();
		void GetForVin();
		void Delete();
	}

	public class RepeatingItemService : ServiceBase, IRepeatingItemService
	{
		public RepeatingItemService(IContext context)
			: base(context)
		{
		}

		public void AddRepeatingItem()
		{
			throw new System.NotImplementedException();
		}

		public void Delete()
		{
			throw new System.NotImplementedException();
		}

		public void GetForVin()
		{
			throw new System.NotImplementedException();
		}
	}
}