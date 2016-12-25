using dotapi.Models.Repositories;
using Microsoft.EntityFrameworkCore;

namespace dotapi.Repositories
{
	public interface IContext 
	{
		DbSet<UserDto> users { get; set; }
		DbSet<PasswordDto> passwords { get; set; }
		DbSet<SessionDto> sessions { get; set; }
	}
	
	public class DatabaseContext : DbContext, IContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options)
			: base(options)
		{ }
		
		public DbSet<UserDto> users { get; set; }
		public DbSet<PasswordDto> passwords { get; set; }
		public DbSet<SessionDto> sessions { get; set; }
	}
}