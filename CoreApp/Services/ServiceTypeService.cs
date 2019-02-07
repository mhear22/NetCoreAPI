using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Models.Vehicle;
using CoreApp.Repositories;

namespace CoreApp.Services
{
	public interface IServiceTypeService
	{
		List<ServiceTypeModel> GetTypes();
		List<RepeatTypeModel> GetRepeats();
	}

	public class ServiceTypeService : ServiceBase, IServiceTypeService
	{
		private ICurrentUserService currentUserService;
		public ServiceTypeService(
			IContext context,
			ICurrentUserService currentUserService
		) : base(context)
		{
			this.currentUserService = currentUserService;
		}

		public List<RepeatTypeModel> GetRepeats()
		{
			return Context.RepeatTypes
				.Select(x => new RepeatTypeModel
				{
					Id = x.Id,
					Name = x.Name
				})
				.ToList();
		}

		public List<ServiceTypeModel> GetTypes()
		{
			var currentUser = this.currentUserService.UserId();
			var premium = this.currentUserService.IsPremium();
			
			return Context.ServiceTypes
				.Where(x=>x.UserId == currentUser || x.UserId == null)
				.ToList()
				.Select(x => new ServiceTypeModel()
				{
					Id = x.Id,
					Name = x.Name,
					Enabled = (x.Premium)?premium:true
				})
				.OrderByDescending(x=>x.Enabled)
				.ToList();
		}
	}
}
