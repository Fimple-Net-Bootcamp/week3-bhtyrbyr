using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPaws.Application.DTOs.PetDTOs;
using VirtualPaws.Application.Exceptions;
using VirtualPaws.Application.Interfaces.Repository.Entities;
using VirtualPaws.Application.Wrappers;

namespace VirtualPaws.Application.Features.Entities.Pets.Queries
{
    public class GetByIdQuery : IRequest<QueryResponse<PetDetailedViewDTO>>
    {
        public UInt16 Id { get; set; }
        public GetByIdQuery(UInt16 ıd)
        {
            Id = ıd;
        }
        public class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, QueryResponse<PetDetailedViewDTO>>
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

            public async Task<QueryResponse<PetDetailedViewDTO>> Handle(GetByIdQuery request, CancellationToken cancellationToken)
            {
                var entity = _petRepo.GetById(request.Id);
                if (entity is not null)
                {
                    if (entity.OwnerId is not null)
                    {
                        entity.Owner = _userRepo.GetById((UInt16)entity.OwnerId);
                    }
                    var result = _mapper.Map<PetDetailedViewDTO>(entity);
                    return new QueryResponse<PetDetailedViewDTO>("Pet Service", "The record was successfully retrieved from the database.", result);
                }
                throw new NoRecordFoundException();
            }
        }
    }
}
