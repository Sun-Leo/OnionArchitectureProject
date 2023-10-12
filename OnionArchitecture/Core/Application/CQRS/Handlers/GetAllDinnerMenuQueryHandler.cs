using Application.CQRS.Queries;
using Application.DTOS.MenuDtos;
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
    public class GetAllDinnerMenuQueryHandler : IRequestHandler<GetAllDinnerMenuQueryRequest, List<ResultDinnerMenuDto>>
    {
        private readonly IRepository<DinnerMenu> _repository;
        private readonly IMapper _mapper;

        public GetAllDinnerMenuQueryHandler(IRepository<DinnerMenu> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<ResultDinnerMenuDto>> Handle(GetAllDinnerMenuQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return _mapper.Map<List<ResultDinnerMenuDto>>(value);
        }
    }
}
