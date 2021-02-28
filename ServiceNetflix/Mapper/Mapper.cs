using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceNetflix.DTO;
using ServiceNetflix.Models;
using AutoMapper;

namespace ServiceNetflix.Mapper
{
    public class Mapper : Profile 
    { 
        public Mapper()
        {
            CreateMap<Plane, PlaneDTO>().ReverseMap();
            
            CreateMap<Paise, PaiseDTO>().ReverseMap();

            CreateMap<CuentaPerfile, CuentaPerfileDTO>().ReverseMap();

            CreateMap<Perfile, PerfileDTO>().ReverseMap();

            CreateMap<ParametrosValor, ParametroValorDTO>().ReverseMap();

            CreateMap<PerfilFavorito, PerfilFavoritoDTO>().ReverseMap();

            CreateMap<ContenidosMultimedium, ContenidoMultimediaDTO>().ReverseMap();

            CreateMap<Video, VideoDTO>().ReverseMap();

            CreateMap<TiposContenidoMultimedium, TiposContenidoMultimediaDTO>().ReverseMap();

        }
    }
}
