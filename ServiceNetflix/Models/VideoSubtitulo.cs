using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class VideoSubtitulo
    {
        public int IdVideoSubtitulo { get; set; }
        public int? IdSubtitulo { get; set; }
        public int? IdVideo { get; set; }

        public virtual Subtitulo IdSubtituloNavigation { get; set; }
        public virtual Video IdVideoNavigation { get; set; }
    }
}
