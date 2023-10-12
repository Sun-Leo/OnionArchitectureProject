using Application.DTOS.OurDishesDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Queries
{
    public class GetAllOurDishesQueryRequest: IRequest<List<ResultOurDishesDto>>
    {
    }
}
