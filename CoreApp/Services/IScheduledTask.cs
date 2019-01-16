using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CoreApp.Services
{
	public interface IScheduledTask
	{
		Task ExecuteAsync(CancellationToken cancellationToken);
	}
}
