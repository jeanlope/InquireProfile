using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class ContenidosMultimedium
    {
        public ContenidosMultimedium()
        {
            ContenidoMultimediaGeneros = new HashSet<ContenidoMultimediaGenero>();
            PerfilFavoritos = new HashSet<PerfilFavorito>();
            Temporada = new HashSet<Temporada>();
        }

        public int IdContenidoMultimedia { get; set; }
        public int? EdadClasificacion { get; set; }
        public int? AnhoPublicacion { get; set; }
        public string Director { get; set; }
        public int? IdVideo { get; set; }
        public int? IdTcontenidoMultimedia { get; set; }

        public virtual TiposContenidoMultimedium IdTcontenidoMultimediaNavigation { get; set; }
        public virtual Video IdVideoNavigation { get; set; }
        public virtual ICollection<ContenidoMultimediaGenero> ContenidoMultimediaGeneros { get; set; }
        public virtual ICollection<PerfilFavorito> PerfilFavoritos { get; set; }
        public virtual ICollection<Temporada> Temporada { get; set; }
    }
}
