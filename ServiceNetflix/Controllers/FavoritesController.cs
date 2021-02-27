using ServiceNetflix.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceNetflix.Models;

namespace ServiceNetflix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteController : ControllerBase
    {
        private readonly NetflixDbContext context;

        public FavoriteController(NetflixDbContext context)
        {
            this.context = context;
        }
        /// <summary>
        /// Obtener favoritos por perfil
        /// </summary>
        // GET: FavoriteController 
        [HttpGet]
        public IEnumerable<PerfilFavorito> Get()
        {
            return context.PerfilFavoritos.ToList();
        }

        
    }
}
