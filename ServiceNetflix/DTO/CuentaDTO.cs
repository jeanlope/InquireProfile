using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceNetflix.DTO
{
    public class CuentaDTO
    {

        public int IdCuenta { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaFacturacion { get; set; }
        public bool? Activo { get; set; }
        public int IdPropietario { get; set; }
        public int IdPlan { get; set; }
    }
}
