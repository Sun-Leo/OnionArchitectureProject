using Application.DTOS.MenuDtos;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public class BreakfastMenuProfiles: Profile
    {
        public BreakfastMenuProfiles()
        {
            CreateMap<CreateBreakfastMenuDto, BreakfastMenu>().ReverseMap();
            CreateMap<ResultBreakfastMenuDto, BreakfastMenu>().ReverseMap();
        }
    }
}
