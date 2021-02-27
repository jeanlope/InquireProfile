using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class Audio
    {
        public Audio()
        {
            EstadoActividades = new HashSet<EstadoActividade>();
            VideoAudios = new HashSet<VideoAudio>();
        }

        public int IdAudio { get; set; }
        public string UrlUbicacion { get; set; }
        public int? IdIdioma { get; set; }

        public virtual Idioma IdIdiomaNavigation { get; set; }
        public virtual ICollection<EstadoActividade> EstadoActividades { get; set; }
        public virtual ICollection<VideoAudio> VideoAudios { get; set; }
    }
}
