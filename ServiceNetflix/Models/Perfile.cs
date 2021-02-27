using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class Perfile
    {
        public Perfile()
        {
            CuentaPerfiles = new HashSet<CuentaPerfile>();
            PerfilActividades = new HashSet<PerfilActividade>();
            PerfilFavoritos = new HashSet<PerfilFavorito>();
        }

        public int IdPerfil { get; set; }
        public string Nombre { get; set; }
        public string UrlAvatar { get; set; }
        public bool? Bloqueado { get; set; }
        public int? EdadClasificacion { get; set; }
        public bool? AutorepSerie { get; set; }
        public bool? AutorepAvances { get; set; }
        public int? IdIdioma { get; set; }

        public virtual Idioma IdIdiomaNavigation { get; set; }
        public virtual ICollection<CuentaPerfile> CuentaPerfiles { get; set; }
        public virtual ICollection<PerfilActividade> PerfilActividades { get; set; }
        public virtual ICollection<PerfilFavorito> PerfilFavoritos { get; set; }
    }
}
