using dotapi.Models.Repositories;
using Microsoft.EntityFrameworkCore;

namespace dotapi.Repositories
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options)
			: base(options)
		{ }
		
		public DbSet<UserDto> Users { get; set; }
		public DbSet<PasswordDto> Passwords { get; set; }
		public DbSet<SessionDto> Sessions { get; set; }
	}
}