using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    // /api/walks
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IWalkReposotory walkReposotory;

        public WalksController(IMapper mapper, IWalkReposotory walkReposotory)
        {
            this.mapper = mapper;
            this.walkReposotory = walkReposotory;
        }


        // Create walk
        //POST: /api/walks
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]AddWalkRequestDto addWalkRequestDto)
        {
            //MAP DTO to Domain Model
            var walkDomainModel = mapper.Map<Walk>(addWalkRequestDto);
            await walkReposotory.CreateAsync(walkDomainModel);


            //Map Domain Model to DTO
            
            return Ok(mapper.Map<WalkDto>(walkDomainModel));

        }
    }
}
