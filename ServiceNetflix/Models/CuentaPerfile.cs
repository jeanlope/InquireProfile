using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class CuentaPerfile
    {
        public int IdCuentaperfil { get; set; }
        public int? IdCuenta { get; set; }
        public int? IdPerfil { get; set; }

        public virtual Cuenta IdCuentaNavigation { get; set; }
        public virtual Perfile IdPerfilNavigation { get; set; }
    }
}
