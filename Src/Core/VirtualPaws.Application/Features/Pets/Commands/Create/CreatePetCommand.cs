using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPaws.Application.DTO_s.PetDTO_s;
using VirtualPaws.Application.Interfaces.Repository;
using VirtualPaws.Domain.Entities;

namespace VirtualPaws.Application.Features.Pets.Commands.Create
{
    public class CreatePetCommand : IRequest<Pet>
    {
        public PetCreateDTO dto { get; set; }
        public class CreatePetCommandHandler : IRequestHandler<CreatePetCommand, Pet>
        {
            private readonly IPetRepository _petRepository;
            private readonly IActivityRepository _activityRepository;
            private readonly IPetHealtStatusRepository _healtRepository;
            private readonly IMapper _maper;

            public CreatePetCommandHandler(IPetRepository petRepository, IActivityRepository activityRepository, IPetHealtStatusRepository healtRepository, IMapper maper)
            {
                _petRepository = petRepository;
                _activityRepository = activityRepository;
                _healtRepository = healtRepository;
                _maper = maper;
            }
            public async Task<Pet> Handle(CreatePetCommand request, CancellationToken cancellationToken)
            {
                var activities = _activityRepository.GetAll();
                var petActivities = new List<Activity>();
                foreach(string activityName in request.dto.ActivityCanBe)
                {
                    petActivities.Add(activities.FirstOrDefault(a => a.Name == activityName));
                };
                var entity = _maper.Map<Pet>(request.dto);
                entity.ActivitiesCanBe = petActivities;
                entity.OwnerId = null;
                entity.Owner = null;
                entity.OwnershipDate = null;
                entity.HungerStatus = 100;
                entity.IsOwned = false;
                entity.IsAlive = true;
                entity.IsVisible = true;
                _petRepository.Create(entity);
                return entity;

            }
        }
    }
}
