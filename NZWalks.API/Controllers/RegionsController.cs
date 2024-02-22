using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Controllers
{
    //https://localhost:port_number/api/regions
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext dbContext;
        public RegionsController(NZWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        //GET ALL REGIONS
        //GET: https://localhost:port_number/api/regions    
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = dbContext.Regions.ToList();           
            return Ok(regions);
        }

        //GET SINGLE REGION (Get Region By Id)
        //GET:  https://localhost:port_number/api/regions/{id}
        [HttpGet]
        [Route("{id}")]

        public IActionResult GetById([FromRoute] Guid id)
        {
            var region = dbContext.Regions.Find(id);

            if (region == null)
            {
                return NotFound();
            }

            return Ok(region);
        }
    }

}
