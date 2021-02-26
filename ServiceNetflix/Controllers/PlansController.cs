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
    public class PlansController : ControllerBase
    {
        private readonly AppDbContext context;

        public PlansController(AppDbContext context)
        {
            this.context = context;
        }

        // GET: PlansController
        [HttpGet]
        public IEnumerable<Perfiles> Get()
        {
            return context.Perfiles.ToList();
        }

       
    }
}
