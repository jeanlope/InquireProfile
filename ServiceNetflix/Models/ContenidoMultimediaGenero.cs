using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class ContenidoMultimediaGenero
    {
        public int IdCmGenero { get; set; }
        public int? IdGenero { get; set; }
        public int? IdContenidoMultimedia { get; set; }

        public virtual ContenidosMultimedium IdContenidoMultimediaNavigation { get; set; }
        public virtual Genero IdGeneroNavigation { get; set; }
    }
}
