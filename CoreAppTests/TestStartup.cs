using CoreApp;
using CoreApp.Services;
using CoreAppTests.Mocks;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAppTests
{
	public class TestStartup : Startup
	{
		public TestStartup(IHostingEnvironment env)
			: base(env, true)
		{
			this.AddServices = (services) => {
				services = StartupHelpers.RegisterService(services);
				services.AddScoped<IStripeService, MockStripeService>();
				services.AddScoped<IEmailSendService, MockEmailSendService>();
				services.AddScoped<ILocalFileSystemService, MockLocalFileSystemService>();
				services.AddSingleton<IConverter, MockConverter>();
				return services;
			};
		}
	}
}
