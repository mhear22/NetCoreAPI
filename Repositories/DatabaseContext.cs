using dotapi.Models.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace dotapi.Repositories
{
	public interface IDatabaseContext
	{
		DbSet<UserDto> users { get; set; }
		DbSet<PasswordDto> passwords { get; set; }
		DbSet<SessionDto> sessions { get; set; }
		DbSet<TEntity> Set<TEntity>() where TEntity : class;
		int SaveChanges();
		EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
	}
	
	public class DatabaseContext : DbContext, IDatabaseContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options)
			: base(options)
		{ }
		
		public DbSet<UserDto> users { get; set; }
		public DbSet<PasswordDto> passwords { get; set; }
		public DbSet<SessionDto> sessions { get; set; }
	}
}