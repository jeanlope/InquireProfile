using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class Temporada
    {
        public Temporada()
        {
            Capitulos = new HashSet<Capitulo>();
        }

        public int IdTemporada { get; set; }
        public int? NroTemporada { get; set; }
        public string Nombre { get; set; }
        public int? IdContenidoMultimedia { get; set; }

        public virtual ContenidosMultimedium IdContenidoMultimediaNavigation { get; set; }
        public virtual ICollection<Capitulo> Capitulos { get; set; }
    }
}
