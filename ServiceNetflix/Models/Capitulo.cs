using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class Capitulo
    {
        public int IdCapitulo { get; set; }
        public int? NroCapitulo { get; set; }
        public int? IdTemporada { get; set; }
        public int? IdVideo { get; set; }

        public virtual Temporada IdTemporadaNavigation { get; set; }
        public virtual Video IdVideoNavigation { get; set; }
    }
}
