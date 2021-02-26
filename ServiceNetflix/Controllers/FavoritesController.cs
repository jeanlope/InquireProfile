using InquireProfile.Contexts;
using InquireProfile.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceNetflix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteController : ControllerBase
    {
        private readonly AppDbContext context;

        public FavoriteController(AppDbContext context)
        {
            this.context = context;
        }

        // GET: FavoriteController 
        [HttpGet]
        public IEnumerable<Perfiles> Get()
        {
            return context.Perfiles.ToList();
        }

        // GET: PerfilController
        [HttpGet("{id}")]
        public Perfiles Get(long id)
        {
            var perfiles = context.Perfiles.FirstOrDefault(p => p.id_perfil == id);
            return perfiles;
        }
    }
}
