using Application.DTOS.CategoriDtos;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public class CategoriProfiles: Profile
    {
        public CategoriProfiles()
        {
            CreateMap<CreateCategoriDto, Category>().ReverseMap();
            CreateMap<UpdateCategoriDto, Category>().ReverseMap();
            CreateMap<ResultCategoriDto, Category>().ReverseMap();
        }
    }
}
