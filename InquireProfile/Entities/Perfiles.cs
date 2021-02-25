using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InquireProfile.Entities
{
    public class Perfiles
    {
        [Key]
        public long id_perfil { get; set; }

        public string nombre { get; set; }

        public string url_avatar { get; set; }

        public long bloqueado { get; set; }

        public int edad_clasificacion { get; set; }
        
        public bool autorep_serie { get; set; }

        public bool autorep_avances { get; set; }

        public int id_idioma { get; set; }

    }
}
