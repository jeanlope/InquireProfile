using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceNetflix.Models
{
    public partial class ParametroLlave
    {
        public ParametroLlave()
        {
            ParametrosValors = new HashSet<ParametrosValor>();
        }

        public long ParamLlaveId { get; set; }
        public string Codigo { get; set; }
        public string Valor { get; set; }
        public bool Enabled { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string ChangeUser { get; set; }

        public virtual ICollection<ParametrosValor> ParametrosValors { get; set; }
    }
}
