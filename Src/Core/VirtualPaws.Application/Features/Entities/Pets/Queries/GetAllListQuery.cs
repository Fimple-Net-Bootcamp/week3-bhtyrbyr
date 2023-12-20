using AutoMapper;
using MediatR;
using VirtualPaws.Application.DTOs.PetDTOs;
using VirtualPaws.Application.Exceptions;
using VirtualPaws.Application.Interfaces.Repository.Entities;
using VirtualPaws.Application.Wrappers;
using VirtualPaws.Domain.Entities;

namespace VirtualPaws.Application.Features.Entities.Pets.Queries
{
    public class GetAllListQuery : IRequest<QueryResponse<List<PetSimplifiedViewDTO>>>
    {
        public class GetAllListQueryHandler : IRequestHandler<GetAllListQuery, QueryResponse<List<PetSimplifiedViewDTO>>>
        {
            private readonly IPetEntityRepository _petRepo;
            private readonly IUserEntityRepository _userRepo;
            private readonly IMapper _mapper;

            public GetAllListQueryHandler(IPetEntityRepository petRepo, 
                                          IUserEntityRepository userRepo, 
                                          IMapper mapper)
            {
                _petRepo = petRepo;
                _userRepo = userRepo;
                _mapper = mapper;
            }

            public async Task<QueryResponse<List<PetSimplifiedViewDTO>>> Handle(GetAllListQuery request, CancellationToken cancellationToken)
            {
                var entities = _petRepo.GetAll();
                if (!entities.Any())
                    throw new NoRecordFoundException("PetRepository");
                entities.ForEach(entity =>
                {
                    if (entity.OwnerId is not null)
                        entity.Owner = _userRepo.GetById((UInt16)entity.OwnerId);
                });
                var result = _mapper.Map<List<PetSimplifiedViewDTO>>(entities);
                return new QueryResponse<List<PetSimplifiedViewDTO>>("Pet Service", "The records were successfully retrieved from the database.", result);
            }
        }
    }
}
