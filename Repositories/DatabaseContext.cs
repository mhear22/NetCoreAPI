using dotapi.Models.Repositories;
using Microsoft.EntityFrameworkCore;

namespace dotapi.Repositories
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options)
			: base(options)
		{
			
		}
		
		public DbSet<UserDto> Users { get; set; }
	}
}