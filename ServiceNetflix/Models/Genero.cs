using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class Genero
    {
        public Genero()
        {
            ContenidoMultimediaGeneros = new HashSet<ContenidoMultimediaGenero>();
        }

        public int IdGenero { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ContenidoMultimediaGenero> ContenidoMultimediaGeneros { get; set; }
    }
}
