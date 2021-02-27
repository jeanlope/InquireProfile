using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class Propietario
    {
        public Propietario()
        {
            Cuenta = new HashSet<Cuenta>();
        }

        public int IdPropietario { get; set; }
        public string Nombres { get; set; }
        public string NroTelefono { get; set; }
        public string Email { get; set; }
        public string Contrasenha { get; set; }
        public int IdPais { get; set; }

        public virtual Paise IdPaisNavigation { get; set; }
        public virtual ICollection<Cuenta> Cuenta { get; set; }
    }
}
