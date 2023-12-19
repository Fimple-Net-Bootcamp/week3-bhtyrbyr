using MediatR;
using VirtualPaws.Application.Interfaces.Repository.Entities;
using VirtualPaws.Domain.Entities;

namespace VirtualPaws.Application.Features.Entities.Pets.Queries
{
    public class GetAllListQuery : IRequest<List<Pet>>
    {
        public class GetAllListQueryHandler : IRequestHandler<GetAllListQuery, List<Pet>>
        {
            private readonly IPetEntityRepository _repo;

            public GetAllListQueryHandler(IPetEntityRepository repo)
            {
                _repo = repo;
            }

            public async Task<List<Pet>> Handle(GetAllListQuery request, CancellationToken cancellationToken)
            {
                var list = _repo.GetAll().Include().OrderBy(pet => pet.Id).ToList();
                return list;
            }
        }
    }
}
