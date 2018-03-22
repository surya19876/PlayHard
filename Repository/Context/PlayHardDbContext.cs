using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository.Context
{
    public class PlayHardDbContext:DbContext
    {
        public PlayHardDbContext(DbContextOptions<PlayHardDbContext> options) : base(options)
        {
        }

        public DbSet<Sports> Sports { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<LocationServices> LocationServices { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sports>(entity =>
            {
                entity.HasKey(e => e.SportsId);
                entity.Property(e => e.SportsName).HasColumnName("SportsName").HasColumnType("varchar(100)");
                entity.Property(e => e.IsActive).HasColumnType("bit");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.LocationId);
                entity.Property(e => e.IsActive).HasColumnType("bit");
                entity.Property(e => e.Address).HasColumnType("varchar(1000)");
                entity.Property(e => e.AddressCoordinateX).HasColumnType("decimal");
                entity.Property(e => e.AddressCoordinateY).HasColumnType("decimal");
                entity.Property(e => e.Landmark).HasColumnType("varchar(1000)");
                entity.Property(e => e.LocationName).HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<LocationServices>(entity =>
            {
                entity.HasKey(e => e.LocationServicesId);
                entity.Property(e => e.LocationId).HasColumnType("int");
                entity.Property(e => e.SportsId).HasColumnType("int");
                entity.Property(e => e.IsActive).HasColumnType("bit");
            });
        }

    }
}
