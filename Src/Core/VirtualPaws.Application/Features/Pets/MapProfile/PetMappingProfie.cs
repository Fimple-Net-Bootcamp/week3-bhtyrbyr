using AutoMapper;
using VirtualPaws.Application.DTO_s.PetDTO_s;
using VirtualPaws.Domain.Entities;

namespace VirtualPaws.Application.Features.Pets.MapProfile
{
    internal class PetMappingProfie : Profile
    {
        public PetMappingProfie()
        {
            CreateMap<Pet, PetSimplifiedViewDTO>();
            CreateMap<Pet, PetDetailedViewDTO>();
        }
    }
}
