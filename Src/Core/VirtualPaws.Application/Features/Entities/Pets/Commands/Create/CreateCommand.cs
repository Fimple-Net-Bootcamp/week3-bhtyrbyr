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
using VirtualPaws.Domain.Entities;

namespace VirtualPaws.Application.Features.Entities.Pets.Commands.Create
{
    public class CreateCommand : IRequest<ServiceCreateResponse>
    {
        public CreateCommand(PetCreateDTO dtoModel)
        {
            this.dtoModel = dtoModel;
        }

        public UInt16 newId { get; set; }

        public PetCreateDTO dtoModel { get; set; }
        public class CreateCommandHandler : IRequestHandler<CreateCommand, ServiceCreateResponse>
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

            public async Task<ServiceCreateResponse> Handle(CreateCommand request, CancellationToken cancellationToken)
            {
                var newPet = _mapper.Map<Pet>(request.dtoModel);
                var activityList = _activityRepo.GetAll().Where(activity =>
                    request.dtoModel.Activities.Contains(activity.Name)
                ).ToList();
                newPet.Level = 1;
                newPet.XP = 1;
                newPet.HungerScore = 100;
                newPet.Activities = activityList;
                newPet.CreateDate = DateTime.Now.Date;
                newPet.UpdateDate = DateTime.Now.Date;
                if (_petRepo.HasEntity(newPet))
                    throw new AlreadyExistException();
                _petRepo.Create(newPet);
                request.newId = newPet.Id;
                return new ServiceCreateResponse("Pet Service", "The pet was successfully registered.");
            }
        }
    }
}
