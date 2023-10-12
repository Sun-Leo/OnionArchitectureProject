﻿using Application.DTOS.MenuDtos;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public class LunchMenuProfiles: Profile
    {
        public LunchMenuProfiles()
        {
            CreateMap<CreateLunchMenuDto, LunchMenu>().ReverseMap();
            CreateMap<ResultLunchMenuDto, LunchMenu>().ReverseMap();
        }
    }
}
