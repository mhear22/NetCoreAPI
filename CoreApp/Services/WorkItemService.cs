using CoreApp.Repositories;

namespace CoreApp.Services
{
	public interface IWorkItemService
	{
		void AddItem();
		void Delete();
		void GetForVin();
	}

	public class WorkItemService : ServiceBase, IWorkItemService
	{
		public WorkItemService(IContext context)
			: base(context)
		{
		}

		public void AddItem()
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