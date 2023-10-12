﻿using Application.DTOS.CategoriDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Queries
{
    public class GetAllCategoriQueryRequest: IRequest<List<ResultCategoriDto>>
    {
    }
}
