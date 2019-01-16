using CoreApp.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CoreApp.Services
{
	public class MileageScheduledTask : ServiceBase, IScheduledTask
	{
		public MileageScheduledTask(IContext context)
			: base(context)
		{ }

		public async Task ExecuteAsync(CancellationToken cancellationToken)
		{
			var Vins = await Context.OwnedCars.Select(x => x.Vin).ToListAsync();
			var FirstVin = Vins.FirstOrDefault();
		}
	}
}
