﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.Product
{
    public class ProductUpsertDto : IDto
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
