﻿using Core.Entities.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MealCategory : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ImagePath { get; set; }
    }
}
