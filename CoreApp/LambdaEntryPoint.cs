using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Amazon.Lambda.AspNetCoreServer;

namespace CoreApp
{
	/// <summary>
	/// This class extends from APIGatewayProxyFunction which contains the method FunctionHandlerAsync which is the 
	/// actual Lambda function entry point. The Lambda handler field should be set to
	/// 
	/// CoreApp::CoreApp.LambdaEntryPoint::FunctionHandlerAsync
	/// </summary>
	public class LambdaEntryPoint : APIGatewayProxyFunction
	{
		/// <summary>
		/// The builder has configuration, logging and Amazon API Gateway already configured. The startup class
		/// needs to be configured in this method using the UseStartup<>() method.
		/// </summary>
		/// <param name="builder"></param>
		protected override void Init(IWebHostBuilder builder)
		{
			builder
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseStartup<Startup>();
		}
	}
}
