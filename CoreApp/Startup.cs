using Amazon;
using Amazon.Lambda.Core;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.SimpleEmail;
using Amazon.SimpleNotificationService;
using CoreApp.Forms;
using CoreApp.Forms.SignUp;
using CoreApp.Forms.Test;
using CoreApp.Models.Repositories;
using CoreApp.Models.Repositories.Vehicle;
using CoreApp.Repositories;
using CoreApp.Services;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.PlatformAbstractions;
using Newtonsoft.Json.Serialization;
using Stripe;
using Swashbuckle.AspNetCore.Swagger;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace CoreApp
{
	public class TestStartup : Startup
	{
		public TestStartup(Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
			: base(env, true)
		{ }
	}
	public class Startup
	{
		private bool IsTesting = false;
		public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment env, bool IsTesting = false)
		{
			this.IsTesting = IsTesting;
			var builder = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
				.AddEnvironmentVariables();
			
			Configuration = builder.Build();
		}

		public IConfigurationRoot Configuration { get; private set; }
		internal static AWSCredentials creds;

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			var connectionString = Configuration.GetSection("DefaultConnection").Value;
			var basePath = PlatformServices.Default.Application.ApplicationBasePath;
			var xmlPath = Path.Combine(basePath, "CoreApp.xml");
			services.AddMvc()
				.AddJsonOptions(x => x.SerializerSettings.ContractResolver = new DefaultContractResolver())
				.AddJsonOptions(x=>x.SerializerSettings.DateTimeZoneHandling= Newtonsoft.Json.DateTimeZoneHandling.Utc);

			services.AddCors(x => x.AddPolicy("cors", z => z.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials()));
			if (IsTesting)
				services.AddDbContext<DatabaseContext>(options => options.UseInMemoryDatabase("Test"), ServiceLifetime.Transient);
			else
				services.AddDbContext<DatabaseContext>(options => options.UseMySql(connectionString));
			
			var opt = Configuration.GetAWSOptions();
			opt.Region = RegionEndpoint.APSoutheast2;

			var key = Configuration.GetSection("AWSKey").Value;
			var secret = Configuration.GetSection("AWSSecret").Value;
			if(!string.IsNullOrWhiteSpace(key))
			{
				LambdaLogger.Log("Using Key and secret");
				opt.Credentials = creds = new BasicAWSCredentials(key, secret);
			}
			else
				LambdaLogger.Log("Using no key");
			
			StripeConfiguration.SetApiKey(Configuration.GetSection("StripeKey").Value);
			services.AddScoped<IStripeService, StripeService>();

			services.AddDefaultAWSOptions(opt);
			services.AddAWSService<IAmazonS3>();
			services.AddAWSService<IAmazonSimpleEmailService>();
			services.AddAWSService<IAmazonSimpleNotificationService>();

			services.AddSingleton<IConfiguration>(Configuration);
			services.AddScoped<IContext, DatabaseContext>();
			services.AddScoped<IEmailSendService, EmailSendService>();
			

			services = StartupHelpers.RegisterService(services);
			
			services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

			services.AddSwaggerGen(x=>
			{
				x.SwaggerDoc("v1", new Info
				{
					Version = "v1",
					Title = "App",
					Description = "Api",
					TermsOfService = "None",
					
				});
				x.IncludeXmlComments(xmlPath);
				x.DescribeAllEnumsAsStrings();
				x.AddSecurityDefinition("apikey", new ApiKeyScheme(){
					Description = "ApiKey",
					In = "header",
					Name = "Authorization",
					Type = "apiKey"
				});
				x.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>>() {
					{ "apikey", new List<string>() }
				});
				x.OperationFilter<SwaggerOperationFilter>();
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			app.UseSwagger();
			app.UseSwaggerUI(x=>
			{
				x.RoutePrefix = "swagger";
				x.SwaggerEndpoint("/swagger/v1/swagger.json", "Api");
				x.InjectStylesheet("/style.css");
			});
			app.UseCors("cors");
			app.UseMvc();
		}
	}

	public static class StartupHelpers
	{
		public static void AddRepo<T>(this IServiceCollection services)
			where T : class, IRow
		{
			services.AddScoped<IRepository<T>, Repository<T>>();
		}

		public static IServiceCollection RegisterService(this IServiceCollection services)
		{
			var ctx = new CustomAssemblyLoader();

			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
				ctx.LoadUnmanagedLibrary(Directory.GetCurrentDirectory() + "/libwkhtmltox.dll");
			else
				ctx.LoadUnmanagedLibrary(Directory.GetCurrentDirectory() + "/libwkhtmltox.so");

			services.AddSingleton<CarReport>();
			services.AddSingleton<SignUpReport>();
			services.AddSingleton<TestReport>();

			services.AddScoped<ICarService, CarService>();
			services.AddScoped<IVinService, VinService>();
			services.AddScoped<IPdfService, PdfService>();
			services.AddScoped<IHtmlService, HtmlService>();
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<IFormService, FormService>();
			services.AddScoped<IEmailService, EmailService>();
			services.AddScoped<IImageService, ImageService>();
			services.AddScoped<IStatusService, StatusService>();
			services.AddScoped<IMileageService, MileageService>();
			services.AddScoped<IStorageService, StorageService>();
			services.AddScoped<IPaymentService, PaymentService>();
			services.AddScoped<IFeedbackService, FeedbackService>();
			services.AddScoped<IWorkItemService, WorkItemService>();
			services.AddScoped<IPasswordService, PasswordService>();
			services.AddScoped<ITokenService, Services.TokenService>();
			services.AddScoped<IPaymentPlanService, PaymentPlanService>();
			services.AddScoped<ICurrentUserService, CurrentUserService>();
			services.AddScoped<IServiceTypeService, ServiceTypeService>();
			services.AddScoped<IHtmlDocumentService, HtmlDocumentService>();
			services.AddScoped<IManufacturerService, ManufacturerService>();
			services.AddScoped<IRepeatingItemService,RepeatingItemService>();
			services.AddScoped<IEmailTemplateService, EmailTemplateService>();
			services.AddScoped<IAuthenticationService, AuthenticationService>();
			services.AddScoped<IReminderReportService, ReminderReportService>();
			services.AddScoped<ILocalFileSystemService, LocalFileSystemService>();
			services.AddSingleton<IConverter>(new SynchronizedConverter(new PdfTools()));

			services.AddRepo<ManufacturerDto>();
			services.AddRepo<FilePiecesDto>();
			services.AddRepo<FilePieceDto>();
			services.AddRepo<OwnedCarDto>();
			services.AddRepo<PasswordDto>();
			services.AddRepo<SessionDto>();
			services.AddRepo<CountryDto>();
			services.AddRepo<UserDto>();
			services.AddRepo<FileDto>();
			services.AddRepo<CarDto>();
			services.AddRepo<VinVDS>();
			services.AddRepo<VinWMI>();
			services.AddRepo<VinVIS>();

			return services;
		}
	}
}