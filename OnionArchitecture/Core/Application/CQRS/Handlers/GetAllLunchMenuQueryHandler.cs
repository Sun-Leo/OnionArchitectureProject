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
    public class GetAllLunchMenuQueryHandler : IRequestHandler<GetAllLunchMenuQueryRequest, List<ResultLunchMenuDto>>
    {
        private readonly IRepository<LunchMenu> _repository;
        private readonly IMapper _mapper;

        public GetAllLunchMenuQueryHandler(IRepository<LunchMenu> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ResultLunchMenuDto>> Handle(GetAllLunchMenuQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return _mapper.Map<List<ResultLunchMenuDto>>(value);
        }
    }
}
