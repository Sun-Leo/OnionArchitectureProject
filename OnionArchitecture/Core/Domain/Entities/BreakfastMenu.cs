﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BreakfastMenu
    {
        public int BreakfastMenuID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string Description { get; set; }
    }
}
