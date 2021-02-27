using System;
using System.Collections.Generic;

namespace ServiceNetflix.DTO
{
    public class PerfileDTO
    {
        public int IdPerfil { get; set; }
        public string Nombre { get; set; }
        public string UrlAvatar { get; set; }
        public bool? Bloqueado { get; set; }
        public int? EdadClasificacion { get; set; }
        public bool? AutorepSerie { get; set; }
        public bool? AutorepAvances { get; set; }
        public ParametroValorDTO Idioma { get; set; }
    }
}
