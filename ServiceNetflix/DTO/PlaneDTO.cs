using ServiceNetflix.Models;
using System;
using System.Collections.Generic;

namespace ServiceNetflix.DTO
{
    public partial class PlaneDTO
    {
        
        public int IdPlan { get; set; }
        public string Nombre { get; set; }
        public decimal? CostoMensual { get; set; }
        public int? CantDispSimult { get; set; }
        public int? CantDispDesc { get; set; }
        public bool? ContenidoIlimitado { get; set; }
        public bool? MultiPlataforma { get; set; }
        public bool? HdDisponible { get; set; }
        public bool? UhdDisponible { get; set; }

        public PaiseDTO Paise { get; set; }
    }
}
