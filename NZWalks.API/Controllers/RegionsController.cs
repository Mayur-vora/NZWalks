using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NZWalks.API.CustomActionFilters;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repositories;
using System.Collections.Generic;

namespace NZWalks.API.Controllers
{
    //https://localhost:port_number/api/regions
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext dbContext;
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(NZWalksDbContext dbContext, IRegionRepository regionRepository,
            IMapper mapper)
        {
            this.dbContext = dbContext;
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }
        //GET ALL REGIONS
        //GET: https://localhost:port_number/api/regions    
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Get Data From Database - Domain Models
            var regionsDomain = await regionRepository.GetAllAsync();

            //Map Domain Models to DTOs
            // Return DTOs to Client
            return Ok(mapper.Map<List<RegionDto>>(regionsDomain));
        }

        //GET SINGLE REGION (Get Region By Id)
        //GET:  https://localhost:port_number/api/regions/{id}
        [HttpGet]
        [Route("{id:Guid}")]

        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            //var region = dbContext.Regions.Find(id);
            //"Find" can only be used withe primary keys so we can just use the method with keys

            //Get Region Domain Model From Database
            var regionDomain = await regionRepository.GetByIdAsync(id);

            if (regionDomain == null)
            {
                return NotFound();
            }

            // Map/Convert Region Domain Model to Region DTO
            // Return DTO back to the client
            return Ok(mapper.Map<RegionDto>(regionDomain));
        }

        // POST To Create New Region
        // POST: https://localhost:port_number/api/regions

        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] AddRegionRequestDto addRegionRequestDto)
        {
           
            // Map or Convert DTO to Domain Model
            var regionDomainModel = mapper.Map<Region>(addRegionRequestDto);

            // Use Domain Model to Create Region
            regionDomainModel = await regionRepository.CreateAsync(regionDomainModel);

            // Map Domain Model Back to DTO

            var regionDto = mapper.Map<RegionDto>(regionDomainModel);

            return CreatedAtAction(nameof(GetById), new { Id = regionDto.Id }, regionDto);
           
        }

        // UPDATE Region
        // PUT: https://localhost:port_number/api/regions/{id}

        [HttpPut]
        [Route("{id:Guid}")]
        [ValidateModel]
        public async Task<IActionResult> UpdateAsync([FromRoute] Guid id, [FromBody] UpdateRegionRequestDto updateRegionRequestDto)
        {
            // Map DTO to Domain Model
            var regionDomainModel = mapper.Map<Region>(updateRegionRequestDto);

            // Check if region exists
            regionDomainModel = await regionRepository.UpdateAsync(id, regionDomainModel);

            if (regionDomainModel == null)
            {
                return NotFound();
            }

            //Convert Domain Model to DTO
            return Ok(mapper.Map<RegionDto>(regionDomainModel));
            

        }

        // DELETE Region
        // DELETE: https://localhost:port_number/api/regions/{id}

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var regionDomainModel = await regionRepository.DeleteAsync(id);

            if (regionDomainModel == null)
            {
                return NotFound();
            }

            // return deleted Region Back
            // map Domain Model to DTO
            return Ok(mapper.Map<RegionDto>(regionDomainModel));

           
        }

    }

}

