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

    public virtual DbSet<InsArchivosPublicacion> InsArchivosPublicacions { get; set; }

    public virtual DbSet<InsComentario> InsComentarios { get; set; }

    public virtual DbSet<InsConversacione> InsConversaciones { get; set; }

    public virtual DbSet<InsGuardado> InsGuardados { get; set; }

    public virtual DbSet<InsHashtag> InsHashtags { get; set; }

    public virtual DbSet<InsHistoria> InsHistorias { get; set; }

    public virtual DbSet<InsLike> InsLikes { get; set; }

    public virtual DbSet<InsLikesHistoria> InsLikesHistorias { get; set; }

    public virtual DbSet<InsMensaje> InsMensajes { get; set; }

    public virtual DbSet<InsNotificacione> InsNotificaciones { get; set; }

    public virtual DbSet<InsParticipantesConversacion> InsParticipantesConversacions { get; set; }

    public virtual DbSet<InsPublicacionHashtag> InsPublicacionHashtags { get; set; }

    public virtual DbSet<InsPublicacione> InsPublicaciones { get; set; }

    public virtual DbSet<InsReporte> InsReportes { get; set; }

    public virtual DbSet<InsRespuestasComentario> InsRespuestasComentarios { get; set; }

    public virtual DbSet<InsSeguidore> InsSeguidores { get; set; }

    public virtual DbSet<InsUsuario> InsUsuarios { get; set; }

    public virtual DbSet<MktComment> MktComments { get; set; }

    public virtual DbSet<MktPost> MktPosts { get; set; }

    public virtual DbSet<MktPostLike> MktPostLikes { get; set; }

    public virtual DbSet<MktUser> MktUsers { get; set; }

    public virtual DbSet<TffAsistencium> TffAsistencia { get; set; }

    public virtual DbSet<TffIntegrante> TffIntegrantes { get; set; }

    public virtual DbSet<TffPago> TffPagos { get; set; }

    public virtual DbSet<TurEquipo> TurEquipos { get; set; }

    public virtual DbSet<TurEquipoApuestum> TurEquipoApuesta { get; set; }

    public virtual DbSet<TurListaTorneo> TurListaTorneos { get; set; }

    public virtual DbSet<TurTorneo> TurTorneos { get; set; }

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

        modelBuilder.Entity<InsArchivosPublicacion>(entity =>
        {
            entity.HasKey(e => e.ArchivoId).HasName("PK__INS_Arch__3D24274A550C309E");

            entity.ToTable("INS_ArchivosPublicacion");

            entity.Property(e => e.TipoArchivo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InsComentario>(entity =>
        {
            entity.HasKey(e => e.ComentarioId).HasName("PK__INS_Come__F18449384E125564");

            entity.ToTable("INS_Comentarios");

            entity.Property(e => e.Comentario).HasMaxLength(1000);
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<InsConversacione>(entity =>
        {
            entity.HasKey(e => e.ConversacionId).HasName("PK__INS_Conv__438B7B59D4D99709");

            entity.ToTable("INS_Conversaciones");

            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<InsGuardado>(entity =>
        {
            entity.HasKey(e => e.GuardadoId).HasName("PK__INS_Guar__8ECEFEB55BCE1FDB");

            entity.ToTable("INS_Guardados");

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<InsHashtag>(entity =>
        {
            entity.HasKey(e => e.HashtagId).HasName("PK__INS_Hash__BEFA912A5D028D33");

            entity.ToTable("INS_Hashtags");

            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<InsHistoria>(entity =>
        {
            entity.HasKey(e => e.HistoriaId).HasName("PK__INS_Hist__0F6B11316BAEF5E5");

            entity.ToTable("INS_Historias");

            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaExpiracion).HasColumnType("datetime");
            entity.Property(e => e.TipoArchivo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InsLike>(entity =>
        {
            entity.HasKey(e => e.LikeId).HasName("PK__INS_Like__A2922C14203B1D20");

            entity.ToTable("INS_Likes");

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<InsLikesHistoria>(entity =>
        {
            entity.HasKey(e => e.LikeHistoriaId).HasName("PK__INS_Like__6041E097967561B7");

            entity.ToTable("INS_LikesHistorias");

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<InsMensaje>(entity =>
        {
            entity.HasKey(e => e.MensajeId).HasName("PK__INS_Mens__FEA0555F56C84313");

            entity.ToTable("INS_Mensajes");

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Leido).HasDefaultValue(false);
        });

        modelBuilder.Entity<InsNotificacione>(entity =>
        {
            entity.HasKey(e => e.NotificacionId).HasName("PK__INS_Noti__BCC12024491F9D2E");

            entity.ToTable("INS_Notificaciones");

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Leida).HasDefaultValue(false);
            entity.Property(e => e.Mensaje).HasMaxLength(500);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InsParticipantesConversacion>(entity =>
        {
            entity.HasKey(e => e.ParticipanteId).HasName("PK__INS_Part__E6DEAC5F6ACC28D6");

            entity.ToTable("INS_ParticipantesConversacion");
        });

        modelBuilder.Entity<InsPublicacionHashtag>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INS_PublicacionHashtag");
        });

        modelBuilder.Entity<InsPublicacione>(entity =>
        {
            entity.HasKey(e => e.PublicacionId).HasName("PK__INS_Publ__10DF158A53CA1596");

            entity.ToTable("INS_Publicaciones");

            entity.Property(e => e.Descripcion).HasMaxLength(2000);
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Ubicacion).HasMaxLength(200);
        });

        modelBuilder.Entity<InsReporte>(entity =>
        {
            entity.HasKey(e => e.ReporteId).HasName("PK__INS_Repo__0B29EA6E99786AAA");

            entity.ToTable("INS_Reportes");

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Motivo).HasMaxLength(500);
        });

        modelBuilder.Entity<InsRespuestasComentario>(entity =>
        {
            entity.HasKey(e => e.RespuestaId).HasName("PK__INS_Resp__31F7FC11A48B4BE3");

            entity.ToTable("INS_RespuestasComentarios");

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Texto).HasMaxLength(1000);
        });

        modelBuilder.Entity<InsSeguidore>(entity =>
        {
            entity.HasKey(e => e.SeguidorId).HasName("PK__INS_Segu__EAE128CFEE3852D5");

            entity.ToTable("INS_Seguidores");

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<InsUsuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__INS_Usua__2B3DE7B8C83152FE");

            entity.ToTable("INS_Usuarios");

            entity.HasIndex(e => e.Username, "UQ__INS_Usua__536C85E4A252FC0C").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__INS_Usua__A9D1053410402AA4").IsUnique();

            entity.Property(e => e.Biografia).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.EsPrivado).HasDefaultValue(false);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.SitioWeb).HasMaxLength(200);
            entity.Property(e => e.Username).HasMaxLength(50);
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

        modelBuilder.Entity<TffAsistencium>(entity =>
        {
            entity.ToTable("TFF_Asistencia");

            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
        });

        modelBuilder.Entity<TffIntegrante>(entity =>
        {
            entity.ToTable("TFF_Integrantes");

            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaIngreso).HasColumnType("datetime");
            entity.Property(e => e.Imagen).IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono).HasMaxLength(20);
        });

        modelBuilder.Entity<TffPago>(entity =>
        {
            entity.ToTable("TFF_Pago");

            entity.Property(e => e.Adeudo).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Periodo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TurEquipo>(entity =>
        {
            entity.ToTable("TUR_EQUIPOS");

            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Equipo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Flag)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TurEquipoApuestum>(entity =>
        {
            entity.ToTable("TUR_EQUIPO_APUESTA");

            entity.Property(e => e.Apuesta).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<TurListaTorneo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TUR_TORNEOS2");

            entity.ToTable("TUR_LISTA_TORNEOS");

            entity.Property(e => e.Apuesta).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NumeroEquipos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TurTorneo>(entity =>
        {
            entity.ToTable("TUR_TORNEOS");

            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
