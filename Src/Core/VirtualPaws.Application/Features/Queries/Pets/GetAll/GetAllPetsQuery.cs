using AutoMapper;
using MediatR;
using VirtualPaws.Application.DTO_s.PetDTO_s;
using VirtualPaws.Application.Interfaces.Repository;

namespace VirtualPaws.Application.Features.Queries.Pets.GetAll
{
    public class GetAllPetsQuery : IRequest<List<PetSimplifiedViewDTO>>
    {
        public class GetAllPetsQueryHandler : IRequestHandler<GetAllPetsQuery, List<PetSimplifiedViewDTO>>
        {
            private readonly IPetRepository repo;
            private readonly IMapper map;

            public GetAllPetsQueryHandler(IPetRepository petRepository, IMapper mapper)
            {
                repo = petRepository;
                map = mapper;
            }
            public async Task<List<PetSimplifiedViewDTO>> Handle(GetAllPetsQuery request, CancellationToken cancellationToken)
            {
                var list = repo.GetAll();
                if (!list.Any()) return null;
                var mappingList = map.Map<List<PetSimplifiedViewDTO>>(list);
                return mappingList;
            }
        }
    }
}
