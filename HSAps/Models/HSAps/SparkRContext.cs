using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HSAps.Models.HSAps;

public partial class SparkRContext : DbContext
{
    private readonly IConfigurationRoot con;
    public SparkRContext()
    {
        con = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
    }

    public SparkRContext(DbContextOptions<SparkRContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Cuisine> Cuisines { get; set; }

    public virtual DbSet<Favorite> Favorites { get; set; }

    public virtual DbSet<Place> Places { get; set; }

    public virtual DbSet<PlaceLocation> PlaceLocations { get; set; }

    public virtual DbSet<PlacePhoto> PlacePhotos { get; set; }

    public virtual DbSet<PriceLevel> PriceLevels { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(con.GetConnectionString("GoOut"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Categori__19093A0B37A0546A");

            entity.HasIndex(e => e.Name, "UX_Categories_Name").IsUnique();

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Icon).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Cuisine>(entity =>
        {
            entity.HasKey(e => e.CuisineId).HasName("PK__Cuisines__B1C3E7CB6FFD894B");

            entity.HasIndex(e => e.Name, "UX_Cuisines_Name").IsUnique();

            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Favorite>(entity =>
        {
            entity.HasKey(e => e.FavoriteId).HasName("PK__Favorite__CE74FAD5199DF38B");

            entity.HasIndex(e => new { e.UserId, e.PlaceId }, "UQ_Favorites_UserPlace").IsUnique();

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
        });

        modelBuilder.Entity<Place>(entity =>
        {
            entity.HasKey(e => e.PlaceId).HasName("PK__Places__D5222B6E53ECE033");

            entity.HasIndex(e => new { e.CategoryId, e.IsActive }, "IX_Places_Category");

            entity.HasIndex(e => e.Name, "IX_Places_Name");

            entity.HasIndex(e => new { e.AverageRating, e.ReviewCount }, "IX_Places_Rating").IsDescending();

            entity.Property(e => e.AverageRating).HasColumnType("decimal(3, 2)");
            entity.Property(e => e.Color)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Emoji).HasMaxLength(10);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<PlaceLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PK__PlaceLoc__E7FEA497E293EFAB");

            entity.HasIndex(e => new { e.Latitude, e.Longitude }, "IX_PlaceLocations_Coordinates");

            entity.HasIndex(e => e.PlaceId, "UQ_PlaceLocations_Place").IsUnique();

            entity.Property(e => e.Address).HasMaxLength(300);
            entity.Property(e => e.Area).HasMaxLength(150);
            entity.Property(e => e.City).HasMaxLength(150);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Latitude).HasColumnType("decimal(10, 7)");
            entity.Property(e => e.Longitude).HasColumnType("decimal(10, 7)");
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(150);
        });

        modelBuilder.Entity<PlacePhoto>(entity =>
        {
            entity.HasKey(e => e.PhotoId).HasName("PK__PlacePho__21B7B5E26DE92751");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.ImageUrl).IsUnicode(false);
        });

        modelBuilder.Entity<PriceLevel>(entity =>
        {
            entity.HasKey(e => e.PriceLevelId).HasName("PK__PriceLev__A25A7556307D290C");

            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Symbol).HasMaxLength(10);
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PK__Reviews__74BC79CE78F1F7B1");

            entity.HasIndex(e => new { e.PlaceId, e.IsActive }, "IX_Reviews_Place");

            entity.HasIndex(e => new { e.PlaceId, e.UserId }, "UQ_Reviews_UserPlace").IsUnique();

            entity.Property(e => e.Comment).HasMaxLength(1500);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4C15BF51C0");

            entity.HasIndex(e => e.Email, "UX_Users_Email").IsUnique();

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.PasswordHash).HasMaxLength(500);
            entity.Property(e => e.ProfileImage).HasMaxLength(500);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
