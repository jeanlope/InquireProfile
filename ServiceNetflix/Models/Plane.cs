using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class Plane
    {
        public Plane()
        {
            Cuenta = new HashSet<Cuenta>();
        }

        public int IdPlan { get; set; }
        public string Nombre { get; set; }
        public decimal? CostoMensual { get; set; }
        public int? CantDispSimult { get; set; }
        public int? CantDispDesc { get; set; }
        public bool? ContenidoIlimitado { get; set; }
        public bool? MultiPlataforma { get; set; }
        public bool? HdDisponible { get; set; }
        public bool? UhdDisponible { get; set; }
        public int? IdPais { get; set; }

        public virtual Paise IdPaisNavigation { get; set; }
        public virtual ICollection<Cuenta> Cuenta { get; set; }
    }
}
