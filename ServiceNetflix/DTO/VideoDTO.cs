using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceNetflix.DTO
{
    public class VideoDTO
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string UrlUbicacion { get; set; }
        public string UrlImagen { get; set; }
        public string UrlTrailer { get; set; }
        public decimal? DuracionSegundos { get; set; }

    }
}
