﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOS.OurDishesDtos
{
    public class CreateOurDishesDto
    {
        public string Description { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

    }
}
