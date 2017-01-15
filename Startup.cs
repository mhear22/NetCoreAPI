using dotapi.Repositories;
using dotapi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MySQL.Data.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;
using dotapi.Models.Repositories;
using System.IO;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.Swagger.Model;
using Newtonsoft.Json.Serialization;
using dotapi.Services.Storage.SQLStore;
using dotapi.Services.Storage;
using dotapi.Actions.User;
using dotapi.Actions.Session;

namespace dotapi
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
			var xmlPath = Path.Combine(basePath, "NetCoreAPI.xml");
			
			services.AddMvc()
				.AddJsonOptions(x=>x.SerializerSettings.ContractResolver = new DefaultContractResolver());
			
			services.AddCors(x=>{
				x.AddPolicy("cors", z=> z.AllowAnyOrigin()
					.AllowAnyMethod()
					.AllowAnyHeader()
					.AllowCredentials()
				);
			});
			if(IsTesting) {
				services.AddDbContext<DatabaseContext>(options => options.UseInMemoryDatabase(),ServiceLifetime.Transient);
			}
			else {
				services.AddDbContext<DatabaseContext>(options => { 
					options.UseMySQL(connectionString);
				});
			}
			services.AddScoped<IContext, DatabaseContext>();
			services.AddScoped<IUserAction, UserAction>();
			services.AddScoped<IGetUserAction, GetUserAction>();
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<ICurrentUserService, CurrentUserService>();
			services.AddScoped<ILogoutAction, LogoutAction>();
			services.AddScoped<IStorageService, SQLStorageService>();
			services.AddScoped<IImageService, ImageService>();
			services.AddScoped<IAuthenticationService, AuthenticationService>();
			services.AddScoped<IPasswordService, PasswordService>();
			services.AddScoped<ITokenService, TokenService>();
			services.AddScoped<IRepository<SessionDto>, Repository<SessionDto>>();
			services.AddScoped<IRepository<PasswordDto>, Repository<PasswordDto>>();
			services.AddScoped<IRepository<UserDto>, Repository<UserDto>>();
			services.AddScoped<IRepository<FileDto>, Repository<FileDto>>();
			services.AddScoped<IRepository<FilePiecesDto>, Repository<FilePiecesDto>>();
			services.AddScoped<IRepository<FilePieceDto>, Repository<FilePieceDto>>();
			services.AddSwaggerGen();
			services.ConfigureSwaggerGen(x =>
			{
				x.SingleApiVersion(new Info
				{
					Version = "v1",
					Title = "App",
					Description = "Api",
					TermsOfService = "None",
				});
				x.IncludeXmlComments(xmlPath);
				x.DescribeAllEnumsAsStrings();
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			app.UseSwagger();
			app.UseSwaggerUi();
			app.UseCors("cors");
			app.UseMvcWithDefaultRoute();
		}
	}
}
