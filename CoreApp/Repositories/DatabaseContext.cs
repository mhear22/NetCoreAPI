using CoreApp.Models.Repositories;
using CoreApp.Models.Repositories.Vehicle;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CoreApp.Repositories
{
	public interface IContext
	{
		DbSet<UserDto> Users { get; set; }
		DbSet<PasswordDto> Passwords { get; set; }
		DbSet<SessionDto> Sessions { get; set; }
		DbSet<FileDto> Files { get; set; }
		DbSet<FilePiecesDto> FilePieces { get; set; }
		DbSet<FilePieceDto> Piece { get; set; }
		DbSet<PostDto> Posts { get; set; }
		DbSet<PostTypeDto> PostTypes { get; set; }
		DbSet<CarDto> Cars { get; set; }
		DbSet<OwnedCarDto> OwnedCars { get; set; }
		DbSet<ManufacturerDto> Manufacturers { get; set; }
		DbSet<VinWMI> VinWMIs { get; set; }
		DbSet<VinVDS> VinVDSs { get; set; }
		DbSet<VinVIS> VinVISs { get; set; }
		DbSet<CountryDto> Countries { get; set; }
		DbSet<MileageRecordingDto> MileageRecordings { get; set; }
		DbSet<RepeatTypeDto> RepeatTypes { get; set; }
		DbSet<ServiceReminderDto> ServiceReminders { get; set; }
		DbSet<ServiceTypeDto> ServiceTypes { get; set; }
		DbSet<ServiceReceiptDto> ServiceReceipts { get; set; }


		DbSet<TEntity> Set<TEntity>() where TEntity : class;
		int SaveChanges();
		EntityEntry Update(object entity);

	}

	public class DatabaseContext : DbContext, IContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options)
			: base(options)
		{ }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			StaticData.Countries.ForEach(x => modelBuilder.Entity<CountryDto>().HasData(x));
			StaticData.Manufacturers.ForEach(x => modelBuilder.Entity<ManufacturerDto>().HasData(x));
			StaticData.WorldManufactuerIdenifier.ForEach(x => modelBuilder.Entity<VinWMI>().HasData(x));
			StaticData.RepeatingTypes.ForEach(x => modelBuilder.Entity<RepeatTypeDto>().HasData(x));
			StaticData.ServiceTypes.ForEach(x => modelBuilder.Entity<ServiceTypeDto>().HasData(x));

			modelBuilder.Entity<OwnedCarDto>(x=> {
				x.HasMany(z=>z.MileageRecordings)
					.WithOne(z=>z.OwnedCar)
					.HasForeignKey(z=>z.OwnedCarId);
			});
		}

		public DbSet<UserDto> Users { get; set; }
		public DbSet<PasswordDto> Passwords { get; set; }
		public DbSet<SessionDto> Sessions { get; set; }
		public DbSet<FileDto> Files { get; set; }
		public DbSet<FilePiecesDto> FilePieces { get; set; }
		public DbSet<FilePieceDto> Piece { get; set; }
		public DbSet<PostDto> Posts { get; set; }
		public DbSet<PostTypeDto> PostTypes { get; set; }
		public DbSet<CarDto> Cars { get; set; }
		public DbSet<OwnedCarDto> OwnedCars { get; set; }
		public DbSet<ManufacturerDto> Manufacturers { get; set; }
		public DbSet<VinWMI> VinWMIs { get; set; }
		public DbSet<VinVDS> VinVDSs { get; set; }
		public DbSet<VinVIS> VinVISs { get; set; }
		public DbSet<CountryDto> Countries { get; set; }
		public DbSet<MileageRecordingDto> MileageRecordings { get; set; }
		public DbSet<RepeatTypeDto> RepeatTypes { get; set; }
		public DbSet<ServiceReminderDto> ServiceReminders { get; set; }
		public DbSet<ServiceTypeDto> ServiceTypes { get; set; }
		public DbSet<ServiceReceiptDto> ServiceReceipts { get; set; }
	}

	public class DatabaseBuilder : IDesignTimeDbContextFactory<DatabaseContext>
	{
		public DatabaseContext CreateDbContext(string[] args)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.AddEnvironmentVariables()
				.Build();
			var builder = new DbContextOptionsBuilder<DatabaseContext>();
			var connectionString = configuration.GetSection("DefaultConnection").Value;
			builder.UseMySql(connectionString);
			return new DatabaseContext(builder.Options);

			throw new System.NotImplementedException();
		}
	}
}