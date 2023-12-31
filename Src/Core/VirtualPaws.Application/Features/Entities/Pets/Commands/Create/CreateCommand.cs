﻿using AutoMapper;
using MediatR;
using VirtualPaws.Application.DTOs.PetDTOs;
using VirtualPaws.Application.Exceptions;
using VirtualPaws.Application.Interfaces.Repository.Entities;
using VirtualPaws.Application.Wrappers;
using VirtualPaws.Domain.Entities;

namespace VirtualPaws.Application.Features.Entities.Pets.Commands.Create
{
    public class CreateCommand : IRequest<ServiceResponse>
    {
        public CreateCommand(PetCreateDTO dtoModel)
        {
            this.dtoModel = dtoModel;
        }

        public UInt16 newId { get; set; }

        public PetCreateDTO dtoModel { get; set; }
        public class CreateCommandHandler : IRequestHandler<CreateCommand, ServiceResponse>
        {
            private readonly IPetEntityRepository _petRepo;
            private readonly IActivityEntityRepository _activityRepo;
            private readonly IMapper _mapper;

            public CreateCommandHandler(IPetEntityRepository petRepo, IActivityEntityRepository activityRepo, IMapper mapper)
            {
                _petRepo = petRepo;
                _activityRepo = activityRepo;
                _mapper = mapper;
            }

            public async Task<ServiceResponse> Handle(CreateCommand request, CancellationToken cancellationToken)
            {
                var newEntity = _mapper.Map<Pet>(request.dtoModel);
                var activityList = _activityRepo.GetAll().Where(activity =>
                    request.dtoModel.Activities.Contains(activity.Name)
                ).ToList();
                newEntity.Activities = activityList;
                if (_petRepo.HasEntity(newEntity))
                    throw new AlreadyExistException();
                _petRepo.Create(newEntity);
                request.newId = newEntity.Id;
                return new ServiceResponse("Pet Service", "The pet was successfully registered.");
            }
        }
    }
}
