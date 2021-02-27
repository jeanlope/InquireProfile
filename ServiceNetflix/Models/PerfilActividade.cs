using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class PerfilActividade
    {
        public PerfilActividade()
        {
            EstadoActividades = new HashSet<EstadoActividade>();
        }

        public int IdPerfilActividad { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdPerfil { get; set; }
        public int? IdVideo { get; set; }

        public virtual Perfile IdPerfilNavigation { get; set; }
        public virtual Video IdVideoNavigation { get; set; }
        public virtual ICollection<EstadoActividade> EstadoActividades { get; set; }
    }
}
