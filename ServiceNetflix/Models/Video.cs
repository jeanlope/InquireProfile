using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class Video
    {
        public Video()
        {
            Capitulos = new HashSet<Capitulo>();
            ContenidosMultimedia = new HashSet<ContenidosMultimedium>();
            PerfilActividades = new HashSet<PerfilActividade>();
            VideoAudios = new HashSet<VideoAudio>();
            VideoSubtitulos = new HashSet<VideoSubtitulo>();
        }

        public int IdVideo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string UrlUbicacion { get; set; }
        public string UrlImagen { get; set; }
        public string UrlTrailer { get; set; }
        public decimal? DuracionSegundos { get; set; }

        public virtual ICollection<Capitulo> Capitulos { get; set; }
        public virtual ICollection<ContenidosMultimedium> ContenidosMultimedia { get; set; }
        public virtual ICollection<PerfilActividade> PerfilActividades { get; set; }
        public virtual ICollection<VideoAudio> VideoAudios { get; set; }
        public virtual ICollection<VideoSubtitulo> VideoSubtitulos { get; set; }
    }
}
