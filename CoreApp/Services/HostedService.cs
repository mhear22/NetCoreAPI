using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CoreApp.Services
{
	public abstract class HostedService : IHostedService
	{
		protected abstract Task ExecuteAsync(CancellationToken cancellationToken);

		private CancellationTokenSource cancellationSource;
		private Task executingTask;

		public Task StartAsync(CancellationToken cancellationToken)
		{
			this.cancellationSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
			this.executingTask = ExecuteAsync(cancellationSource.Token);
			return this.executingTask.IsCompleted ? this.executingTask : Task.CompletedTask;
		}

		public async Task StopAsync(CancellationToken cancellationToken)
		{
			if (this.executingTask == null)
				return;
			this.cancellationSource.Cancel();
			await Task.WhenAny(this.executingTask, Task.Delay(-1, cancellationToken));
			cancellationToken.ThrowIfCancellationRequested();
		}
	}
}
