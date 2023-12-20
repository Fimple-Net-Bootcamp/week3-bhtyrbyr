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

namespace VirtualPaws.Application.Features.Entities.Pets.Commands.Update
{
    public class UpdatePutCommand : IRequest<ServiceResponse>
    {
        public PetUpdateDTO dtoModel { get; set; }
        public UInt16 Id { get; set; }

        public UpdatePutCommand(UInt16 Id, PetUpdateDTO dtoModel)
        {
            this.Id = Id;
            this.dtoModel = dtoModel;
        }
        public class UpdatePutCommandHandler : IRequestHandler<UpdatePutCommand, ServiceResponse>
        {
            private readonly IPetEntityRepository _petRepo;
            private readonly IUserEntityRepository _userRepo;
            private readonly IMapper _mapper;

            public UpdatePutCommandHandler(IPetEntityRepository petRepo, IUserEntityRepository userRepo, IMapper mapper)
            {
                _petRepo = petRepo;
                _userRepo = userRepo;
                _mapper = mapper;
            }


            public async Task<ServiceResponse> Handle(UpdatePutCommand request, CancellationToken cancellationToken)
            {
                var petEntity = _petRepo.GetById(request.Id);
                if (petEntity is null)
                    throw new NoRecordFoundException("PetRepository");
                petEntity.Name = (request.dtoModel.NewName != "string" && request.dtoModel.NewName != null) ? request.dtoModel.NewName : petEntity.Name;
                petEntity.Type = (request.dtoModel.NewType != "string" && request.dtoModel.NewType != null) ? request.dtoModel.NewType : petEntity.Type;
                petEntity.Level = request.dtoModel.NewLevel != default ? request.dtoModel.NewLevel : petEntity.Level;
                petEntity.XP = request.dtoModel.NewXP != default ? request.dtoModel.NewXP : petEntity.XP;
                petEntity.HungerScore = request.dtoModel.NewHungerScore != default ? request.dtoModel.NewHungerScore : petEntity.HungerScore;
                petEntity.UpdateDate = DateTime.Now;
                _petRepo.Update(petEntity);
                return new ServiceResponse("Pet Service", $"The record named {petEntity.Name} has been successfully updated.");
            }
        }
    }
}
