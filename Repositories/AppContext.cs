using dotapi.Models.Repositories;
using Microsoft.EntityFrameworkCore;

namespace dotapi.Repositories
{
	public class AppContext : DbContext
	{
		public AppContext(DbContextOptions<AppContext> options)
			: base(options)
		{
			
		}
		
		public DbSet<UserDto> Users { get; set; }
	}
}