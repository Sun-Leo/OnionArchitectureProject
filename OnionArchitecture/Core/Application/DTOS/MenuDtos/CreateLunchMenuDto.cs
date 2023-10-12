using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOS.MenuDtos
{
    public class CreateLunchMenuDto
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string Description { get; set; }
    }
}
