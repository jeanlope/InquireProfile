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
    public class ProfileController : ControllerBase
    {
        private readonly NetflixDbContext context;
        private readonly IMapper _mapper;

        public ProfileController(NetflixDbContext context, IMapper mapper)
        {
            this.context = context;
            this._mapper = mapper;
        }
        
        /// <summary>
        /// Obtener perfiles por cuenta
        /// </summary>
        // GET: PerfilController
        [HttpGet("{idCuenta}")]
        public IEnumerable<PerfileDTO> Get(long idCuenta)
        {
            
            List<CuentaPerfile> cuentaPerfiles = context.CuentaPerfiles.Where(p => p.IdCuentaNavigation.IdCuenta == idCuenta).ToList();
            List<PerfileDTO> perfilesDTO = new List<PerfileDTO>();
            foreach (CuentaPerfile cuentaPerfil in cuentaPerfiles)
            {

                var perfil = context.Perfiles.FirstOrDefault(p => p.IdPerfil == cuentaPerfil.IdPerfil);
                var parametrosValors = context.ParametrosValors.FirstOrDefault(p => p.ParamValueId == perfil.IdIdioma);

                var perfilDTO = _mapper.Map<PerfileDTO>(perfil);
                var parametroValorDTO = _mapper.Map<ParametroValorDTO>(parametrosValors);

                perfilDTO.Idioma = parametroValorDTO;
                perfilesDTO.Add(perfilDTO);
                
            }
            
            return perfilesDTO;
        }
    }
}
