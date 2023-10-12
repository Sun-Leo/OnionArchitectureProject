using Application.CQRS.Queries;
using Application.DTOS.AboutDtos;
using Application.DTOS.ProductDtos;
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
    public class GetAllAboutQueryHandler : IRequestHandler<GetAllAboutQueryRequest, List<ResultAboutDto>>
    {
        private readonly IRepository<About> _repository;
        private readonly IMapper _mapper;

        public GetAllAboutQueryHandler(IRepository<About> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ResultAboutDto>> Handle(GetAllAboutQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return _mapper.Map<List<ResultAboutDto>>(value);

        }
    }
}
