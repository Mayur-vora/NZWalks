using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Controllers
{
    //https://localhost:port_number/api/regions
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        //GET ALL REGIONS
        //GET: https://localhost:port_number/api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Aukland Region",
                    Code = "AKL",
                    RegionImageUrl = "https://www.leeabbamonte.com/wp-content/uploads/2016/02/IMG_4179.jpg"
                },
                new Region
                {
                     Id = Guid.NewGuid(),
                    Name = "Wellington Region",
                    Code = "WLG",
                    RegionImageUrl = "https://www.wallpapers-for-desktop.eu/desktop/8203-panorama-city-new-of-wellington-8203-zeland.jpg"
                },

            };

            return Ok(regions);
        }
    }
}
