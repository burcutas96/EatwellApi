﻿using Core.Entities.Abstract;
using Entities.Dtos.City;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.Country
{
    public class CountryDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CityDto> Cities { get; set; }
    }
}
