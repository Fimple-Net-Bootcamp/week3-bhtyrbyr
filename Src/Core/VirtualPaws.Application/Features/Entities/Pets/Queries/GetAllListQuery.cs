using AutoMapper;
using MediatR;
using VirtualPaws.Application.DTOs.PetDTOs;
using VirtualPaws.Application.Interfaces.Repository.Entities;
using VirtualPaws.Domain.Entities;

namespace VirtualPaws.Application.Features.Entities.Pets.Queries
{
    public class GetAllListQuery : IRequest<List<PetSimplifiedViewDTO>>
    {
        public class GetAllListQueryHandler : IRequestHandler<GetAllListQuery, List<PetSimplifiedViewDTO>>
        {
            private readonly IPetEntityRepository _petRepo;
            private readonly IUserEntityRepository _userRepo;
            private readonly IActivityEntityRepository _acrivityRepo;
            private readonly IMapper _mapper;

            public GetAllListQueryHandler(IPetEntityRepository petRepo, 
                                          IUserEntityRepository userRepo, 
                                          IActivityEntityRepository acrivityRepo,
                                          IMapper mapper)
            {
                _petRepo = petRepo;
                _userRepo = userRepo;
                _acrivityRepo = acrivityRepo;
                _mapper = mapper;
            }

            public async Task<List<PetSimplifiedViewDTO>> Handle(GetAllListQuery request, CancellationToken cancellationToken)
            {
                var _pets = _petRepo.GetAll();
                _pets.ForEach(pet =>
                {
                    if (pet.OwnerId is not null)
                        pet.Owner = _userRepo.GetById((UInt16)pet.OwnerId);
                });
                var result = _mapper.Map<List<PetSimplifiedViewDTO>>(_pets);
                return result;
            }
        }
    }
}
