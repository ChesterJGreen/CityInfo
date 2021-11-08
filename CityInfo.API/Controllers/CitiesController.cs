using CityInfo.API.Models;
using CityInfo.API.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        private readonly ICityInfoRepository _cityInfoRepository;

        public CitiesController(ICityInfoRepository cityInfoRepository)
        {
            _cityInfoRepository = cityInfoRepository ?? throw new ArgumentNullException(nameof(cityInfoRepository));
        }

        [HttpGet]
        public IActionResult GetCities()
        {
            var cityEntities = _cityInfoRepository.GetCities();
            var results = new List<CityWithoutPointsOfInterestDto>();
            foreach (var cityEntity in cityEntities)
            {
                results.Add(new CityWithoutPointsOfInterestDto
                {
                    Id = cityEntity.Id,
                    Description = cityEntity.Description,
                    Name = cityEntity.Name
                });
            }
            return Ok(results);


        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var CityToReturn =
                CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (CityToReturn == null)
            {
                return NotFound();
            }
            return Ok(CityToReturn);

        }
        /* [HttpPost]
        {
        } */

    }
}

