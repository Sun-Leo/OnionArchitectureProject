using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOS.CategoriDtos
{
    public class UpdateCategoriDto
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Image { get; set; }
    }
}
