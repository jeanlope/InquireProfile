using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class EstadoActividade
    {
        public int IdEstadoActividad { get; set; }
        public decimal? Volumen { get; set; }
        public decimal? SegundoReproduccion { get; set; }
        public decimal? Velocidad { get; set; }
        public int? IdPerfilActividad { get; set; }
        public int? IdAudio { get; set; }
        public int? IdSubtitulo { get; set; }

        public virtual Audio IdAudioNavigation { get; set; }
        public virtual PerfilActividade IdPerfilActividadNavigation { get; set; }
        public virtual Subtitulo IdSubtituloNavigation { get; set; }
    }
}
