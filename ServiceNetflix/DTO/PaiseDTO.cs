using System;
using System.Collections.Generic;




namespace ServiceNetflix.DTO
{
    public partial class PaiseDTO
    {
        
        public string Nombre { get; set; }
        public string Siglas { get; set; }
        //public ParametroValorDTO ParametroValor { get; set; }
        public ParametroValorDTO Moneda { get; set; }

    }
}
