using ServiceNetflix.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceNetflix.Models;
using ServiceNetflix.DTO;
using AutoMapper;

namespace ServiceNetflix.Controllers

{

    [Route("api/[controller]")]
    [ApiController]
    
    public class FavoriteController : ControllerBase
    {
        private readonly NetflixDbContext context;
        private readonly IMapper _mapper;

        public FavoriteController(NetflixDbContext context, IMapper mapper)
        {
            this.context = context;
            this._mapper = mapper;

        }
        /// <summary>
        /// Obtener favoritos por perfil
        /// </summary>
        // GET: FavoriteController 
        [HttpGet("{idPerfilFavorito}")]
        public IEnumerable<PerfilFavoritoDTO> Get(int idPerfilFavorito)
        {
            var perfilFavoritos = context.PerfilFavoritos.Where(p => p.IdPerfilfavorito == idPerfilFavorito).ToList();
            List<PerfilFavoritoDTO> perfilFavoritosDTO = new List<PerfilFavoritoDTO>();

            foreach (PerfilFavorito perfilFavorito in perfilFavoritos)
            {

                var contenidoMultimedia = context.ContenidosMultimedia.FirstOrDefault(p => p.IdContenidoMultimedia == perfilFavorito.IdContenidoMultimedia);
                var video = context.Videos.FirstOrDefault(p => p.IdVideo == contenidoMultimedia.IdVideo);
                var tipoContenidoMultimedia = context.TiposContenidoMultimedia.FirstOrDefault(p => p.IdTcontenidoMultimedia == contenidoMultimedia.IdTcontenidoMultimedia);
                
                var contenidoMultimediaDTO = _mapper.Map<ContenidoMultimediaDTO>(contenidoMultimedia);
                var videoDTO = _mapper.Map<VideoDTO>(video);
                var tipoContenidoMultimediaDTO = _mapper.Map<TiposContenidoMultimediaDTO>(tipoContenidoMultimedia);
                var perfilFavoritoDTO = _mapper.Map<PerfilFavoritoDTO>(perfilFavorito);

                contenidoMultimediaDTO.Video = videoDTO;
                contenidoMultimediaDTO.TipoContenidoMultimedia = tipoContenidoMultimediaDTO;
                perfilFavoritoDTO.ContenidoMultimedia = contenidoMultimediaDTO;

                perfilFavoritosDTO.Add(perfilFavoritoDTO);
            }

            return perfilFavoritosDTO;
        }

    }
}
