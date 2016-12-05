using dotapi.Repositories;
using dotapi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MySQL.Data.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;

namespace dotapi
{
	public class TestStartup : Startup
	{
		public TestStartup() 
			: base(true)
		{
			
		}
	}
    public class Startup
    {
		private bool IsTesting = false;
		public Startup() { }
		public Startup(bool isTesting)
		{ 
			IsTesting = isTesting;
		}
		
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
			var connectionString = this.Configuration.GetConnectionString("DefaultConnection");
            services.AddMvc();
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
			
			
			services.AddSingleton<IAuthenticationService, AuthenticationService>();
			services.AddSingleton<IPasswordService, PasswordService>();
			services.AddSingleton<ITokenService, TokenService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
			app.UseCors("cors");
            app.UseMvc();
        }
    }
}
