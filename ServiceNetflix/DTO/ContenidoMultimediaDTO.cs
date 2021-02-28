using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceNetflix.DTO
{
    public class ContenidoMultimediaDTO
    {
        public int? EdadClasificacion { get; set; }
        public int? AnhoPublicacion { get; set; }
        public string Director { get; set; }
        public VideoDTO Video { get; set; }
        public TiposContenidoMultimediaDTO TipoContenidoMultimedia { get; set; }

    }
}
