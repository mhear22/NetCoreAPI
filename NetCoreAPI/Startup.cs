using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using dotapi.Repositories;
using dotapi.Services.Storage;
using dotapi.Services;
using Microsoft.Extensions.PlatformAbstractions;
using System.IO;
using Newtonsoft.Json.Serialization;
using dotapi.Actions.User;
using dotapi.Actions.Session;
using dotapi.Models.Repositories;

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
			var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
			var connectionString = Configuration.GetConnectionString("DefaultConnection");
			var basePath = PlatformServices.Default.Application.ApplicationBasePath;
			var xmlPath = Path.Combine(basePath, "NetCoreAPI.xml");

			services.AddMvc()
				.AddJsonOptions(x => x.SerializerSettings.ContractResolver = new DefaultContractResolver());

			services.AddCors(x => {
				x.AddPolicy("cors", z => z.AllowAnyOrigin()
					.AllowAnyMethod()
					.AllowAnyHeader()
					.AllowCredentials()
				);
			});
			if (IsTesting)
			{
				//services.AddDbContext<DatabaseContext>(options => options.UseInMemoryDatabase(), ServiceLifetime.Transient);
			}
			else
			{
				//services.AddDbContext<DatabaseContext>(options => {
				//	options.UseMySQL(connectionString);
				//});
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
			//services.AddSwaggerGen();
			//services.ConfigureSwaggerGen(x =>
			//{
			//	x.SingleApiVersion(new Info
			//	{
			//		Version = "v1",
			//		Title = "App",
			//		Description = "Api",
			//		TermsOfService = "None",
			//	});
			//	x.IncludeXmlComments(xmlPath);
			//	x.DescribeAllEnumsAsStrings();
			//});
		}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
