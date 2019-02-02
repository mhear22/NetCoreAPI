using CoreApp.Repositories;
using System.Linq;

namespace CoreApp.Services
{
	public interface IRepeatingItemService
	{
		void AddRepeatingItem(AddRepeatingSettings model);
		void Delete(string Id);
	}

	public class RepeatingItemService : ServiceBase, IRepeatingItemService
	{
		public RepeatingItemService(IContext context)
			: base(context)
		{
		}

		public void AddRepeatingItem(AddRepeatingSettings model)
		{
			var reminder = Context.ServiceReminders.FirstOrDefault(x => x.Id == model.Id);

			reminder.RepeatingTypeId = model.TypeId;
			reminder.RepeatingFigure = model.Amount;

			Context.SaveChanges();
		}

		public void Delete(string Id)
		{
			var reminder = Context.ServiceReminders.FirstOrDefault(x => x.Id == Id);

			reminder.RepeatingTypeId = null;
			reminder.RepeatingFigure = null;

			Context.SaveChanges();
		}
	}

	public class AddRepeatingSettings
	{
		public string Id;
		public string TypeId;
		public string Amount;
	}
}