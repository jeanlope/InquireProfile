using InquireProfile.Contexts;
using InquireProfile.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InquireProfile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly AppDbContext context;

        public ProfileController(AppDbContext context)
        {
            this.context = context;
        }

        // GET: PerfilController
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
