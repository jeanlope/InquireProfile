using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class ParametrosValor
    {
        public ParametrosValor()
        {
            Paises = new HashSet<Paise>();
        }

        public long ParamValueId { get; set; }
        public long ParamLlaveId { get; set; }
        public string Codigo { get; set; }
        public string Valor { get; set; }
        public bool? Enabled { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string ChangeUser { get; set; }

        public virtual ParametroLlave ParamLlave { get; set; }
        public virtual ICollection<Paise> Paises { get; set; }
    }
}
