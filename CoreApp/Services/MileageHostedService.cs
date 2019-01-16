using CoreApp.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CoreApp.Services
{
	public class MileageHostedService : HostedService
	{
		private List<IScheduledTask> _tasks = new List<IScheduledTask>();

		public MileageHostedService(IEnumerable<IScheduledTask> tasks)
		{
			var refTime = DateTime.UtcNow;

			foreach(var task in tasks)
			{
				_tasks.Add(task);
			}
		}

		protected override async Task ExecuteAsync(CancellationToken cancellationToken)
		{
			while(!cancellationToken.IsCancellationRequested)
			{
				await ExecuteOnceAsync(cancellationToken);
				//await Task.Delay(TimeSpan.FromDays(1), cancellationToken);
				await Task.Delay(TimeSpan.FromMinutes(1), cancellationToken);
			}
		}

		private async Task ExecuteOnceAsync(CancellationToken cancellationToken)
		{
			var factory = new TaskFactory(TaskScheduler.Current);
			_tasks.ForEach(x =>
			{
				factory.StartNew(async () =>
				{
					await x.ExecuteAsync(cancellationToken);
				});
			});

		}
	}
}
