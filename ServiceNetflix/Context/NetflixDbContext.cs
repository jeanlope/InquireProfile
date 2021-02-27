using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ServiceNetflix.Models;
#nullable disable

namespace ServiceNetflix.Context
{
    public partial class NetflixDbContext : DbContext
    {
        public NetflixDbContext()
        {
        }

        public NetflixDbContext(DbContextOptions<NetflixDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Audio> Audios { get; set; }
        public virtual DbSet<Capitulo> Capitulos { get; set; }
        public virtual DbSet<ContenidoMultimediaGenero> ContenidoMultimediaGeneros { get; set; }
        public virtual DbSet<ContenidosMultimedium> ContenidosMultimedia { get; set; }
        public virtual DbSet<Cuenta> Cuentas { get; set; }
        public virtual DbSet<CuentaPerfile> CuentaPerfiles { get; set; }
        public virtual DbSet<EstadoActividade> EstadoActividades { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<Idioma> Idiomas { get; set; }
        public virtual DbSet<Paise> Paises { get; set; }
        public virtual DbSet<ParametroLlave> ParametroLlaves { get; set; }
        public virtual DbSet<ParametrosValor> ParametrosValors { get; set; }
        public virtual DbSet<PerfilActividade> PerfilActividades { get; set; }
        public virtual DbSet<PerfilFavorito> PerfilFavoritos { get; set; }
        public virtual DbSet<Perfile> Perfiles { get; set; }
        public virtual DbSet<Plane> Planes { get; set; }
        public virtual DbSet<Propietario> Propietarios { get; set; }
        public virtual DbSet<Subtitulo> Subtitulos { get; set; }
        public virtual DbSet<Temporada> Temporadas { get; set; }
        public virtual DbSet<TiposContenidoMultimedium> TiposContenidoMultimedia { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<VideoAudio> VideoAudios { get; set; }
        public virtual DbSet<VideoSubtitulo> VideoSubtitulos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=dbnetflix.caqsrlfngfbe.us-east-1.rds.amazonaws.com\\\\\\\\SQLEXPRESS,1433;Database=netflixdb;User ID=admin;Password=N3tfl1x2021;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Audio>(entity =>
            {
                entity.HasKey(e => e.IdAudio);

                entity.ToTable("audios");

                entity.Property(e => e.IdAudio).HasColumnName("id_audio");

                entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");

                entity.Property(e => e.UrlUbicacion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("url_ubicacion");

                entity.HasOne(d => d.IdIdiomaNavigation)
                    .WithMany(p => p.Audios)
                    .HasForeignKey(d => d.IdIdioma)
                    .HasConstraintName("FK_audios_idiomas");
            });

            modelBuilder.Entity<Capitulo>(entity =>
            {
                entity.HasKey(e => e.IdCapitulo);

                entity.ToTable("capitulos");

                entity.Property(e => e.IdCapitulo).HasColumnName("id_capitulo");

                entity.Property(e => e.IdTemporada).HasColumnName("id_temporada");

                entity.Property(e => e.IdVideo).HasColumnName("id_video");

                entity.Property(e => e.NroCapitulo).HasColumnName("nro_capitulo");

                entity.HasOne(d => d.IdTemporadaNavigation)
                    .WithMany(p => p.Capitulos)
                    .HasForeignKey(d => d.IdTemporada)
                    .HasConstraintName("FK_capitulos_contenido_multimedia_temporadas");

                entity.HasOne(d => d.IdVideoNavigation)
                    .WithMany(p => p.Capitulos)
                    .HasForeignKey(d => d.IdVideo)
                    .HasConstraintName("FK_capitulos_videos");
            });

            modelBuilder.Entity<ContenidoMultimediaGenero>(entity =>
            {
                entity.HasKey(e => e.IdCmGenero);

                entity.ToTable("contenido_multimedia_generos");

                entity.Property(e => e.IdCmGenero).HasColumnName("id_cm_genero");

                entity.Property(e => e.IdContenidoMultimedia).HasColumnName("id_contenido_multimedia");

                entity.Property(e => e.IdGenero).HasColumnName("id_genero");

                entity.HasOne(d => d.IdContenidoMultimediaNavigation)
                    .WithMany(p => p.ContenidoMultimediaGeneros)
                    .HasForeignKey(d => d.IdContenidoMultimedia)
                    .HasConstraintName("FK_contenido_multimedia_generos_contenidos_multimedia");

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany(p => p.ContenidoMultimediaGeneros)
                    .HasForeignKey(d => d.IdGenero)
                    .HasConstraintName("FK_contenido_multimedia_generos_generos");
            });

            modelBuilder.Entity<ContenidosMultimedium>(entity =>
            {
                entity.HasKey(e => e.IdContenidoMultimedia);

                entity.ToTable("contenidos_multimedia");

                entity.Property(e => e.IdContenidoMultimedia).HasColumnName("id_contenido_multimedia");

                entity.Property(e => e.AnhoPublicacion).HasColumnName("anho_publicacion");

                entity.Property(e => e.Director)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("director");

                entity.Property(e => e.EdadClasificacion).HasColumnName("edad_clasificacion");

                entity.Property(e => e.IdTcontenidoMultimedia).HasColumnName("id_tcontenido_multimedia");

                entity.Property(e => e.IdVideo).HasColumnName("id_video");

                entity.HasOne(d => d.IdTcontenidoMultimediaNavigation)
                    .WithMany(p => p.ContenidosMultimedia)
                    .HasForeignKey(d => d.IdTcontenidoMultimedia)
                    .HasConstraintName("FK_contenidos_multimedia_tipos_contenido_multimedia");

                entity.HasOne(d => d.IdVideoNavigation)
                    .WithMany(p => p.ContenidosMultimedia)
                    .HasForeignKey(d => d.IdVideo)
                    .HasConstraintName("FK_contenidos_multimedia_videos");
            });

            modelBuilder.Entity<Cuenta>(entity =>
            {
                entity.HasKey(e => e.IdCuenta);

                entity.ToTable("cuentas");

                entity.Property(e => e.IdCuenta).HasColumnName("id_cuenta");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaFacturacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_facturacion");

                entity.Property(e => e.IdPlan).HasColumnName("id_plan");

                entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");

                entity.HasOne(d => d.IdPlanNavigation)
                    .WithMany(p => p.Cuenta)
                    .HasForeignKey(d => d.IdPlan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cuentas_planes");

                entity.HasOne(d => d.IdPropietarioNavigation)
                    .WithMany(p => p.Cuenta)
                    .HasForeignKey(d => d.IdPropietario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cuentas_propietarios");
            });

            modelBuilder.Entity<CuentaPerfile>(entity =>
            {
                entity.HasKey(e => e.IdCuentaperfil);

                entity.ToTable("cuenta_perfiles");

                entity.Property(e => e.IdCuentaperfil).HasColumnName("id_cuentaperfil");

                entity.Property(e => e.IdCuenta).HasColumnName("id_cuenta");

                entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.CuentaPerfiles)
                    .HasForeignKey(d => d.IdCuenta)
                    .HasConstraintName("FK_cuenta_perfiles_cuentas");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.CuentaPerfiles)
                    .HasForeignKey(d => d.IdPerfil)
                    .HasConstraintName("FK_cuenta_perfiles_perfiles");
            });

            modelBuilder.Entity<EstadoActividade>(entity =>
            {
                entity.HasKey(e => e.IdEstadoActividad);

                entity.ToTable("estado_actividades");

                entity.Property(e => e.IdEstadoActividad).HasColumnName("id_estado_actividad");

                entity.Property(e => e.IdAudio).HasColumnName("id_audio");

                entity.Property(e => e.IdPerfilActividad).HasColumnName("id_perfil_actividad");

                entity.Property(e => e.IdSubtitulo).HasColumnName("id_subtitulo");

                entity.Property(e => e.SegundoReproduccion)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("segundo_reproduccion");

                entity.Property(e => e.Velocidad)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("velocidad");

                entity.Property(e => e.Volumen)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("volumen");

                entity.HasOne(d => d.IdAudioNavigation)
                    .WithMany(p => p.EstadoActividades)
                    .HasForeignKey(d => d.IdAudio)
                    .HasConstraintName("FK_estado_actividades_audios");

                entity.HasOne(d => d.IdPerfilActividadNavigation)
                    .WithMany(p => p.EstadoActividades)
                    .HasForeignKey(d => d.IdPerfilActividad)
                    .HasConstraintName("FK_estado_actividades_perfil_actividades");

                entity.HasOne(d => d.IdSubtituloNavigation)
                    .WithMany(p => p.EstadoActividades)
                    .HasForeignKey(d => d.IdSubtitulo)
                    .HasConstraintName("FK_estado_actividades_subtitulos");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.IdGenero);

                entity.ToTable("generos");

                entity.Property(e => e.IdGenero).HasColumnName("id_genero");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("text")
                    .HasColumnName("descripcion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Idioma>(entity =>
            {
                entity.HasKey(e => e.IdIdioma);

                entity.ToTable("idiomas");

                entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Paise>(entity =>
            {
                entity.HasKey(e => e.IdPais);

                entity.ToTable("paises");

                entity.Property(e => e.IdPais).HasColumnName("id_pais");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Siglas)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("siglas");

                entity.Property(e => e.TipoMoneda).HasColumnName("tipo_moneda");

                entity.HasOne(d => d.TipoMonedaNavigation)
                    .WithMany(p => p.Paises)
                    .HasForeignKey(d => d.TipoMoneda)
                    .HasConstraintName("paises_FK");
            });

            modelBuilder.Entity<ParametroLlave>(entity =>
            {
                entity.HasKey(e => e.ParamLlaveId)
                    .HasName("parametro_llave_PK");

                entity.ToTable("parametro_llave");

                entity.Property(e => e.ParamLlaveId).HasColumnName("param_llave_id");

                entity.Property(e => e.ChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("change_date");

                entity.Property(e => e.ChangeUser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("change_user");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("create_user");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<ParametrosValor>(entity =>
            {
                entity.HasKey(e => e.ParamValueId)
                    .HasName("parametros_valor_PK");

                entity.ToTable("parametros_valor");

                entity.Property(e => e.ParamValueId).HasColumnName("param_value_id");

                entity.Property(e => e.ChangeDate)
                    .HasColumnType("date")
                    .HasColumnName("change_date");

                entity.Property(e => e.ChangeUser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("change_user");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("codigo");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasColumnName("create_date");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("create_user");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.ParamLlaveId).HasColumnName("param_llave_id");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("valor");

                entity.HasOne(d => d.ParamLlave)
                    .WithMany(p => p.ParametrosValors)
                    .HasForeignKey(d => d.ParamLlaveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("parametros_valor_FK");
            });

            modelBuilder.Entity<PerfilActividade>(entity =>
            {
                entity.HasKey(e => e.IdPerfilActividad);

                entity.ToTable("perfil_actividades");

                entity.Property(e => e.IdPerfilActividad).HasColumnName("id_perfil_actividad");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");

                entity.Property(e => e.IdVideo).HasColumnName("id_video");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.PerfilActividades)
                    .HasForeignKey(d => d.IdPerfil)
                    .HasConstraintName("FK_perfil_actividades_perfiles");

                entity.HasOne(d => d.IdVideoNavigation)
                    .WithMany(p => p.PerfilActividades)
                    .HasForeignKey(d => d.IdVideo)
                    .HasConstraintName("FK_perfil_actividades_videos");
            });

            modelBuilder.Entity<PerfilFavorito>(entity =>
            {
                entity.HasKey(e => e.IdPerfilfavorito)
                    .HasName("PK_perfil_lista");

                entity.ToTable("perfil_favoritos");

                entity.Property(e => e.IdPerfilfavorito).HasColumnName("id_perfilfavorito");

                entity.Property(e => e.IdContenidoMultimedia).HasColumnName("id_contenido_multimedia");

                entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");

                entity.HasOne(d => d.IdContenidoMultimediaNavigation)
                    .WithMany(p => p.PerfilFavoritos)
                    .HasForeignKey(d => d.IdContenidoMultimedia)
                    .HasConstraintName("FK_perfil_lista_contenidos_multimedia");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.PerfilFavoritos)
                    .HasForeignKey(d => d.IdPerfil)
                    .HasConstraintName("FK_perfil_lista_perfiles");
            });

            modelBuilder.Entity<Perfile>(entity =>
            {
                entity.HasKey(e => e.IdPerfil);

                entity.ToTable("perfiles");

                entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");

                entity.Property(e => e.AutorepAvances).HasColumnName("autorep_avances");

                entity.Property(e => e.AutorepSerie).HasColumnName("autorep_serie");

                entity.Property(e => e.Bloqueado).HasColumnName("bloqueado");

                entity.Property(e => e.EdadClasificacion).HasColumnName("edad_clasificacion");

                entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UrlAvatar)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("url_avatar");

                entity.HasOne(d => d.IdIdiomaNavigation)
                    .WithMany(p => p.Perfiles)
                    .HasForeignKey(d => d.IdIdioma)
                    .HasConstraintName("FK_perfiles_idiomas");
            });

            modelBuilder.Entity<Plane>(entity =>
            {
                entity.HasKey(e => e.IdPlan);

                entity.ToTable("planes");

                entity.Property(e => e.IdPlan).HasColumnName("id_plan");

                entity.Property(e => e.CantDispDesc).HasColumnName("cant_disp_desc");

                entity.Property(e => e.CantDispSimult).HasColumnName("cant_disp_simult");

                entity.Property(e => e.ContenidoIlimitado).HasColumnName("contenido_ilimitado");

                entity.Property(e => e.CostoMensual)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("costo_mensual");

                entity.Property(e => e.HdDisponible).HasColumnName("hd_disponible");

                entity.Property(e => e.IdPais).HasColumnName("id_pais");

                entity.Property(e => e.MultiPlataforma).HasColumnName("multi_plataforma");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.UhdDisponible).HasColumnName("uhd_disponible");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Planes)
                    .HasForeignKey(d => d.IdPais)
                    .HasConstraintName("planes_FK");
            });

            modelBuilder.Entity<Propietario>(entity =>
            {
                entity.HasKey(e => e.IdPropietario);

                entity.ToTable("propietarios");

                entity.Property(e => e.IdPropietario).HasColumnName("id_propietario");

                entity.Property(e => e.Contrasenha)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("contrasenha");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdPais).HasColumnName("id_pais");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombres");

                entity.Property(e => e.NroTelefono)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("nro_telefono");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Propietarios)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_propietarios_paises");
            });

            modelBuilder.Entity<Subtitulo>(entity =>
            {
                entity.HasKey(e => e.IdSubtitulo);

                entity.ToTable("subtitulos");

                entity.Property(e => e.IdSubtitulo).HasColumnName("id_subtitulo");

                entity.Property(e => e.IdIdioma).HasColumnName("id_idioma");

                entity.Property(e => e.UrlUbicacion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("url_ubicacion");

                entity.HasOne(d => d.IdIdiomaNavigation)
                    .WithMany(p => p.Subtitulos)
                    .HasForeignKey(d => d.IdIdioma)
                    .HasConstraintName("FK_subtitulos_idiomas");
            });

            modelBuilder.Entity<Temporada>(entity =>
            {
                entity.HasKey(e => e.IdTemporada)
                    .HasName("PK_contenido_multimedia_temporadas");

                entity.ToTable("temporadas");

                entity.Property(e => e.IdTemporada).HasColumnName("id_temporada");

                entity.Property(e => e.IdContenidoMultimedia).HasColumnName("id_contenido_multimedia");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NroTemporada).HasColumnName("nro_temporada");

                entity.HasOne(d => d.IdContenidoMultimediaNavigation)
                    .WithMany(p => p.Temporada)
                    .HasForeignKey(d => d.IdContenidoMultimedia)
                    .HasConstraintName("FK_contenido_multimedia_temporadas_contenidos_multimedia");
            });

            modelBuilder.Entity<TiposContenidoMultimedium>(entity =>
            {
                entity.HasKey(e => e.IdTcontenidoMultimedia);

                entity.ToTable("tipos_contenido_multimedia");

                entity.Property(e => e.IdTcontenidoMultimedia).HasColumnName("id_tcontenido_multimedia");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.HasKey(e => e.IdVideo);

                entity.ToTable("videos");

                entity.Property(e => e.IdVideo).HasColumnName("id_video");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("text")
                    .HasColumnName("descripcion");

                entity.Property(e => e.DuracionSegundos)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("duracion_segundos");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("titulo");

                entity.Property(e => e.UrlImagen)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("url_imagen");

                entity.Property(e => e.UrlTrailer)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("url_trailer");

                entity.Property(e => e.UrlUbicacion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("url_ubicacion");
            });

            modelBuilder.Entity<VideoAudio>(entity =>
            {
                entity.HasKey(e => e.IdVideoAudio);

                entity.ToTable("video_audios");

                entity.Property(e => e.IdVideoAudio).HasColumnName("id_video_audio");

                entity.Property(e => e.IdAudio).HasColumnName("id_audio");

                entity.Property(e => e.IdVideo).HasColumnName("id_video");

                entity.HasOne(d => d.IdAudioNavigation)
                    .WithMany(p => p.VideoAudios)
                    .HasForeignKey(d => d.IdAudio)
                    .HasConstraintName("FK_video_audios_audios");

                entity.HasOne(d => d.IdVideoNavigation)
                    .WithMany(p => p.VideoAudios)
                    .HasForeignKey(d => d.IdVideo)
                    .HasConstraintName("FK_video_audios_videos");
            });

            modelBuilder.Entity<VideoSubtitulo>(entity =>
            {
                entity.HasKey(e => e.IdVideoSubtitulo);

                entity.ToTable("video_subtitulos");

                entity.Property(e => e.IdVideoSubtitulo).HasColumnName("id_video_subtitulo");

                entity.Property(e => e.IdSubtitulo).HasColumnName("id_subtitulo");

                entity.Property(e => e.IdVideo).HasColumnName("id_video");

                entity.HasOne(d => d.IdSubtituloNavigation)
                    .WithMany(p => p.VideoSubtitulos)
                    .HasForeignKey(d => d.IdSubtitulo)
                    .HasConstraintName("FK_video_subtitulos_subtitulos");

                entity.HasOne(d => d.IdVideoNavigation)
                    .WithMany(p => p.VideoSubtitulos)
                    .HasForeignKey(d => d.IdVideo)
                    .HasConstraintName("FK_video_subtitulos_videos");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
