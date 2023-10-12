using Application.DTOS.OurDishesDtos;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public class OurDishesProfiles: Profile
    {
        public OurDishesProfiles()
        {
            CreateMap<CreateOurDishesDto, OurDishes>().ReverseMap();
            CreateMap<ResultOurDishesDto, OurDishes>().ReverseMap();
            CreateMap<UpdateOurDishesDto, OurDishes>().ReverseMap();
        }
    }
}
