using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class Subtitulo
    {
        public Subtitulo()
        {
            EstadoActividades = new HashSet<EstadoActividade>();
            VideoSubtitulos = new HashSet<VideoSubtitulo>();
        }

        public int IdSubtitulo { get; set; }
        public string UrlUbicacion { get; set; }
        public int? IdIdioma { get; set; }

        public virtual Idioma IdIdiomaNavigation { get; set; }
        public virtual ICollection<EstadoActividade> EstadoActividades { get; set; }
        public virtual ICollection<VideoSubtitulo> VideoSubtitulos { get; set; }
    }
}
