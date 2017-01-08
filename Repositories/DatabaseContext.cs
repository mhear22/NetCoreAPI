using dotapi.Models.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace dotapi.Repositories
{
	public interface IContext 
	{
		DbSet<UserDto> users { get; set; }
		DbSet<PasswordDto> passwords { get; set; }
		DbSet<SessionDto> sessions { get; set; }
		DbSet<TEntity> Set<TEntity>() where TEntity : class;
		int SaveChanges();
		EntityEntry Update(object entity);
		
	}
	
	public class DatabaseContext : DbContext, IContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options)
			: base(options)
		{ }
		
		public DbSet<UserDto> users { get; set; }
		public DbSet<PasswordDto> passwords { get; set; }
		public DbSet<SessionDto> sessions { get; set; }
		public DbSet<FileDto> files { get; set; }
		public DbSet<FilePiecesDto> filePieces { get; set; }
		public DbSet<FilePieceDto> piece { get; set; }
	}
}