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

    public virtual DbSet<DmHorario> DmHorarios { get; set; }

    public virtual DbSet<MktComment> MktComments { get; set; }

    public virtual DbSet<MktPost> MktPosts { get; set; }

    public virtual DbSet<MktPostLike> MktPostLikes { get; set; }

    public virtual DbSet<MktUser> MktUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(con.GetConnectionString("MKT"));


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DmHorario>(entity =>
        {
            entity.ToTable("DM_Horario");

            entity.Property(e => e.Dia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Edificio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Eliminar).HasDefaultValue(0);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.Hora)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Materia)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Salon)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MktComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MKT_Comm__3214EC0795971BE9");

            entity.ToTable("MKT_Comments");

            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MktPost>(entity =>
        {
            entity.ToTable("MKT_Post");

            entity.Property(e => e.Contenido).IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.Imagen).IsUnicode(false);
            entity.Property(e => e.VideoUrl)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MktPostLike>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MKT_Post__3214EC07EF30EDEA");

            entity.ToTable("MKT_PostLikes");

            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MktUser>(entity =>
        {
            entity.ToTable("MKT_Users");

            entity.Property(e => e.Apellidos)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.App)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Grado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Imagen).IsUnicode(false);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.Matricula)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Seccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
