using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPaws.Application.DTO_s.PetDTO_s;
using VirtualPaws.Application.Interfaces.Repository;

namespace VirtualPaws.Application.Features.Pets.Queries.GetById
{
    public class GetByIdPetQuery : IRequest<PetDetailedViewDTO>
    {
        public int Id { get; set; }
        public class GetByIdPetQueryHandler : IRequestHandler<GetByIdPetQuery, PetDetailedViewDTO>
        {
            private readonly IPetRepository _repository;
            private readonly IMapper _mapper;
            public GetByIdPetQueryHandler(IPetRepository repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }
            public async Task<PetDetailedViewDTO> Handle(GetByIdPetQuery request, CancellationToken cancellationToken)
            {
                var item = _repository.GetById(request.Id);
                if (item is null) { }
                return _mapper.Map<PetDetailedViewDTO>(item);
            }
        }
    }
}
