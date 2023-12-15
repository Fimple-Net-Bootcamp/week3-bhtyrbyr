using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPaws.Application.Interfaces.Repository;
using VirtualPaws.Domain.Entities;

namespace VirtualPaws.Application.Features.Pets.Queries.GetEntity
{
    public class GetPetEntityQuery : IRequest<List<Pet>>
    {
        public class GetPetEntityQueryHandler : IRequestHandler<GetPetEntityQuery, List<Pet>>
        {
            private readonly IPetRepository repository;
            public GetPetEntityQueryHandler(IPetRepository petRepository)
            {
                repository = petRepository;               
            }
            public async Task<List<Pet>> Handle(GetPetEntityQuery request, CancellationToken cancellationToken)
            {
                return repository.GetAll();
            }
        }
    }
}
