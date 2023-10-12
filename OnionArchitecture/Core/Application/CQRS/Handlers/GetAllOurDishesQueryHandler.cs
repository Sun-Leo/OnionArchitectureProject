using Application.CQRS.Queries;
using Application.DTOS.OurDishesDtos;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Handlers
{
    public class GetAllOurDishesQueryHandler : IRequestHandler<GetAllOurDishesQueryRequest, List<ResultOurDishesDto>>
    {
        private readonly IRepository<OurDishes> _repository;
        private readonly IMapper _mapper;

        public GetAllOurDishesQueryHandler(IRepository<OurDishes> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ResultOurDishesDto>> Handle(GetAllOurDishesQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return _mapper.Map<List<ResultOurDishesDto>>(value);
        }
    }
}
