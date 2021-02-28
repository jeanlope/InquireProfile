using ServiceNetflix.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceNetflix.Models;
using AutoMapper;
using ServiceNetflix.DTO;


namespace ServiceNetflix.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]


    public class PlansController : ControllerBase
    {
        private readonly NetflixDbContext context;
        private readonly IMapper _mapper;

        public PlansController(NetflixDbContext context, IMapper mapper)
        {
            this.context = context;
            this._mapper = mapper;
        }

        /// <summary>
        /// Obtener planes por pais
        /// </summary>
        // GET: PlansController
        [HttpGet("{codePais}")]
        public IEnumerable<PlaneDTO> Get(string codePais)
        {
            var planes = context.Planes.Where( p => p.IdPaisNavigation.Siglas == codePais).ToList();
            List<PlaneDTO> planesDTO = new List<PlaneDTO>();

            foreach (Plane plane in planes)
            {
                var pais = context.Paises.FirstOrDefault(p => p.IdPais == plane.IdPais);
                var parametrosValors = context.ParametrosValors.FirstOrDefault(p => p.ParamValueId == pais.TipoMoneda);

                var paisDTO = _mapper.Map<PaiseDTO>(pais);
                var parametroValorDTO = _mapper.Map<ParametroValorDTO>(parametrosValors);
                var planDTO = _mapper.Map<PlaneDTO>(plane);

                paisDTO.Moneda = parametroValorDTO;
                planDTO.Paise = paisDTO;
                planesDTO.Add(planDTO);

            }

            return planesDTO;
        }
    }
}
