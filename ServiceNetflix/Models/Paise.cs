using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class Paise
    {
        public Paise()
        {
            Planes = new HashSet<Plane>();
            Propietarios = new HashSet<Propietario>();
        }

        public int IdPais { get; set; }
        public string Nombre { get; set; }
        public string Siglas { get; set; }
        public long? TipoMoneda { get; set; }

        public virtual ParametrosValor TipoMonedaNavigation { get; set; }
        public virtual ICollection<Plane> Planes { get; set; }
        public virtual ICollection<Propietario> Propietarios { get; set; }
    }
}
