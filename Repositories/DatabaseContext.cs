using dotapi.Models.Repositories;
using Microsoft.EntityFrameworkCore;

namespace dotapi.Repositories
{
	public interface IDatabaseContext
	{
		int SaveChanges();
		
		DbSet<UserDto> Users { get; set; }
		DbSet<PasswordDto> Passwords { get; set; }
		DbSet<SessionDto> Sessions { get; set; }
	}
	public class DatabaseContext : DbContext, IDatabaseContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options)
			: base(options)
		{ }
		
		public DbSet<UserDto> Users { get; set; }
		public DbSet<PasswordDto> Passwords { get; set; }
		public DbSet<SessionDto> Sessions { get; set; }
	}
}