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
            private readonly IPetRepository _petRepository;
            private readonly IUserRepository _usertRepository;
           // private readonly IActivityRepository _activityRepository;
            public GetPetEntityQueryHandler(IPetRepository petRepository, IUserRepository userRepository, IActivityRepository activityRepository)
            {
                _petRepository = petRepository;
                _usertRepository = userRepository;
                //_activityRepository = activityRepository;
            }
            public async Task<List<Pet>> Handle(GetPetEntityQuery request, CancellationToken cancellationToken)
            {
                var petList = _petRepository.GetAll();
                var userList = _usertRepository.GetAll();
                //var activityList = _activityRepository.GetAll();

                /*petList.ForEach(pet =>
                {
                    pet.Owner = userList.FirstOrDefault(user => user.Id == pet.Id);
                });*/
                return petList;
            }
        }
    }
}
