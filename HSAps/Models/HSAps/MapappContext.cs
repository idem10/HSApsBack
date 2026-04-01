using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HSAps.Models.HSAps;

public partial class MapappContext : DbContext
{
    private readonly IConfigurationRoot con;
    public MapappContext()
    {
        con = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
    }

    public MapappContext(DbContextOptions<MapappContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MktUser> MktUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(con.GetConnectionString("MKT"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MktUser>(entity =>
        {
            entity.ToTable("MKT_Users");

            entity.Property(e => e.Apellidos)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Imagen).IsUnicode(false);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
