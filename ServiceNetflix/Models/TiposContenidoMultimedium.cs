using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class TiposContenidoMultimedium
    {
        public TiposContenidoMultimedium()
        {
            ContenidosMultimedia = new HashSet<ContenidosMultimedium>();
        }

        public int IdTcontenidoMultimedia { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<ContenidosMultimedium> ContenidosMultimedia { get; set; }
    }
}
