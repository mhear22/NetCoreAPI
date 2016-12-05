using dotapi.Models.Repositories;
using Microsoft.EntityFrameworkCore;

namespace dotapi.Repositories
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options)
			: base(options)
		{ }
		
		public DbSet<UserDto> users { get; set; }
		public DbSet<PasswordDto> passwords { get; set; }
		public DbSet<SessionDto> sessions { get; set; }
	}
}