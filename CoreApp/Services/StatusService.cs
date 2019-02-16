using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.S3;
using CoreApp.Forms;
using CoreApp.Forms.SignUp;
using CoreApp.Repositories;
using Microsoft.Extensions.Hosting;

namespace CoreApp.Services
{
	public interface IStatusService
	{
		bool TryGetService<T>();
		ServiceStatusModel GetServiceStatus();
	}

	public class StatusService : ServiceBase, IStatusService
	{
		private IServiceProvider serviceProvider;

		public StatusService(
			IContext context,
			IServiceProvider serviceProvider
		) : base(context)
		{
			this.serviceProvider = serviceProvider;
		}

		public T GetService<T>()
		{
			return (T)this.serviceProvider.GetService(typeof(T));
		}

		public bool TryGetService<T>()
		{
			try
			{
				GetService<T>();
				return true;
			}
			catch {
				return true;
			}
		}

		public ServiceStatusModel GetServiceStatus()
		{
			var result = new ServiceStatusModel()
			{
				CarReport = TryGetService<CarReport>(),
				SignUpReport = TryGetService<SignUpReport>(),
				HostedService = TryGetService<IHostedService>(),
			};
			try
			{
				result.IScheduledTasks = GetService<IEnumerable<IScheduledTask>>().Count();
			}
			catch { }

			try
			{
				var service = GetService<IAmazonS3>();

				result.S3Buckets = service.ListBucketsAsync().Result.Buckets
					.Select(x => x.BucketName)
					.ToList();
			}
			catch (Exception ex) { result.S3Buckets.Add(ex.Message); }

			return result;
		}
	}

	public class ServiceStatusModel
	{
		public bool CarReport;
		public bool SignUpReport;
		public int IScheduledTasks;
		public bool HostedService;
		public List<string> S3Buckets = new List<string>();
	}
}
