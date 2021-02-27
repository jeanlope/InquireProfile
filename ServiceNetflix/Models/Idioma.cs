using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class Idioma
    {
        public Idioma()
        {
            Audios = new HashSet<Audio>();
            Perfiles = new HashSet<Perfile>();
            Subtitulos = new HashSet<Subtitulo>();
        }

        public int IdIdioma { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Audio> Audios { get; set; }
        public virtual ICollection<Perfile> Perfiles { get; set; }
        public virtual ICollection<Subtitulo> Subtitulos { get; set; }
    }
}
