using Application.DTOS.MenuDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Queries
{
    public class GetAllBreakfastMenuQueryRequest: IRequest<List<ResultBreakfastMenuDto>>
    {
    }
}
