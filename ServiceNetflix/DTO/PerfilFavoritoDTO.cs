﻿using System;
using System.Collections.Generic;

namespace ServiceNetflix.DTO
{
    public partial class PerfilFavoritoDTO
    {
        public int IdPerfilfavorito { get; set; }
        public int? IdPerfil { get; set; }
        public virtual ContenidoMultimediaDTO ContenidoMultimedia { get; set; }
    }
}
