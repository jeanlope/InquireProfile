using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class PerfilFavorito
    {
        public int IdPerfilfavorito { get; set; }
        public int? IdPerfil { get; set; }
        public int? IdContenidoMultimedia { get; set; }

        public virtual ContenidosMultimedium IdContenidoMultimediaNavigation { get; set; }
        public virtual Perfile IdPerfilNavigation { get; set; }
    }
}
