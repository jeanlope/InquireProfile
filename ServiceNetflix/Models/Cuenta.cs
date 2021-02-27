using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class Cuenta
    {
        public Cuenta()
        {
            CuentaPerfiles = new HashSet<CuentaPerfile>();
        }

        public int IdCuenta { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaFacturacion { get; set; }
        public bool? Activo { get; set; }
        public int IdPropietario { get; set; }
        public int IdPlan { get; set; }

        public virtual Plane IdPlanNavigation { get; set; }
        public virtual Propietario IdPropietarioNavigation { get; set; }
        public virtual ICollection<CuentaPerfile> CuentaPerfiles { get; set; }
    }
}
