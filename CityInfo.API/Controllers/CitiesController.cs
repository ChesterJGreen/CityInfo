﻿using CityInfo.API.Models;
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
        [HttpGet]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);


        }

        [HttpGet("/{id}")]
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
        [HttpPost]


    }
}
