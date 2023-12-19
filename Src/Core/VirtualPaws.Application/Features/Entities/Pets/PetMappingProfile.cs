using AutoMapper;
using VirtualPaws.Application.DTOs.PetDTOs;
using VirtualPaws.Domain.Entities;

namespace VirtualPaws.Application.Features.Entities.Pets
{
    internal class PetMappingProfile : Profile
    {
        public PetMappingProfile()
        {
            CreateMap<Pet, PetSimplifiedViewDTO>()
                .ForMember(
                    src => src.OwnerName, opt => opt.MapFrom(prop => prop.Owner == null ? "Sahipsiz" : prop.Owner.Name)
                ).ReverseMap();
        }
    }
}
