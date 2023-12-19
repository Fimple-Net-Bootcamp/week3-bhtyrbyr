using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPaws.Application.DTOs.PetDTOs;
using VirtualPaws.Application.Interfaces.Repository.Entities;

namespace VirtualPaws.Application.Features.Entities.Pets.Queries
{
    public class GetByIdQuery : IRequest<PetDetailedViewDTO>
    {
        public UInt16 Id { get; set; }
        public GetByIdQuery(UInt16 ıd)
        {
            Id = ıd;
        }
        public class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, PetDetailedViewDTO>
        {
            private readonly IPetEntityRepository _petRepo;
            private readonly IUserEntityRepository _userRepo;
            private readonly IMapper _mapper;

            public GetByIdQueryHandler(IPetEntityRepository petRepo,
                                          IUserEntityRepository userRepo,
                                          IMapper mapper)
            {
                _petRepo = petRepo;
                _userRepo = userRepo;
                _mapper = mapper;
            }
            public async Task<PetDetailedViewDTO> Handle(GetByIdQuery request, CancellationToken cancellationToken)
            {
                var _pet = _petRepo.GetById(request.Id);
                if(_pet is not null)
                {
                    if (_pet.OwnerId is not null)
                    {
                        _pet.Owner = _userRepo.GetById((UInt16)_pet.OwnerId);
                    }
                    var result = _mapper.Map<PetDetailedViewDTO>(_pet);
                    return result;
                }
                return null;
            }
        }
    }
}
