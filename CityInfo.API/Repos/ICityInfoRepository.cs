﻿using CityInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Repos
{
    public interface ICityInfoRepository
    {
        IEnumerable<City> GetCities();
        City GetCity(int cityId);
        IEnumerable<PointOfInterest> GetPointsOfInterestForCity(int cityId);
        PointOfInterest GetPointOfInterestForCity(int cityId, int pointOfInterestId);
    }
}
