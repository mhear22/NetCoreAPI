using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using CoreApp.Models.Repositories;
using CoreApp.Models.Repositories.Vehicle;
using CoreApp.Repositories;
using CoreApp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.PlatformAbstractions;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.Swagger;
using System.Collections.Generic;
using System.IO;

namespace CoreApp
{
	public class TestStartup : Startup
	{
		public TestStartup(IHostingEnvironment env)
			: base(env, true)
		{ }
	}
	public class Startup
	{
		private bool IsTesting = false;
		public Startup(IHostingEnvironment env, bool IsTesting = false)
		{
			this.IsTesting = IsTesting;
			var builder = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
				.AddEnvironmentVariables();
			
			Configuration = builder.Build();
		}

		public IConfigurationRoot Configuration { get; private set; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			var connectionString = Configuration.GetConnectionString("DefaultConnection");
			var basePath = PlatformServices.Default.Application.ApplicationBasePath;
			var xmlPath = Path.Combine(basePath, "CoreApp.xml");
			services.AddMvc().AddJsonOptions(x => x.SerializerSettings.ContractResolver = new DefaultContractResolver());
			services.AddCors(x => x.AddPolicy("cors", z => z.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials()));
			if (IsTesting)
				services.AddDbContext<DatabaseContext>(options => options.UseInMemoryDatabase("Test"), ServiceLifetime.Transient);
			else
				services.AddDbContext<DatabaseContext>(options => options.UseMySql(connectionString));
			var key = Configuration.GetSection("AWSKey").Value;
			var secret = Configuration.GetSection("AWSSecret").Value;
			var opt = Configuration.GetAWSOptions();
			opt.Region = RegionEndpoint.APSoutheast2;
			opt.Credentials = new BasicAWSCredentials(key, secret);
			
			services.AddDefaultAWSOptions(opt);
			services.AddAWSService<IAmazonS3>();
			services.AddScoped<IContext, DatabaseContext>();

			services = StartupHelpers.RegisterService(services);

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
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			app.UseSwagger();
			app.UseSwaggerUI(x=>
			{
				x.RoutePrefix = "swagger";
				x.SwaggerEndpoint("/swagger/v1/swagger.json", "Api");
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
			services.AddScoped<ICarService, CarService>();
			services.AddScoped<ICurrentUserService, CurrentUserService>();
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<IStorageService, StorageService>();
			services.AddScoped<IAuthenticationService, AuthenticationService>();
			services.AddScoped<IPasswordService, PasswordService>();
			services.AddScoped<ITokenService, TokenService>();

			services.AddRepo<SessionDto>();
			services.AddRepo<PasswordDto>();
			services.AddRepo<UserDto>();
			services.AddRepo<FileDto>();
			services.AddRepo<FilePiecesDto>();
			services.AddRepo<FilePieceDto>();
			services.AddRepo<ManufacturerDto>();
			services.AddRepo<OwnedCarDto>();
			services.AddRepo<CarDto>();
			services.AddRepo<CountryDto>();
			services.AddRepo<VinVDS>();
			services.AddRepo<VinWMI>();
			services.AddRepo<VinVIS>();

			services.AddScoped<IImageService, ImageService>();
			services.AddScoped<IManufacturerService, ManufacturerService>();
			services.AddScoped<IVinService, VinService>();
			services.AddScoped<ICountryService, CountryService>();
			return services;
		}
	}
}