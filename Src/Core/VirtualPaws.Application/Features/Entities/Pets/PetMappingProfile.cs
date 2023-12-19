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
                    src => src.OwnerName, opt => opt.MapFrom(prop => prop.Owner == null ? "Sahipsiz" : $"{prop.Owner.Name} {prop.Owner.Surname.Substring(0,2)}***")
                ).ReverseMap();
            CreateMap<Pet, PetDetailedViewDTO>()
                .ForMember(
                    src => src.OwnerName, opt => opt.MapFrom(prop => prop.Owner == null ? "Sahipsiz" : $"{prop.Owner.Name} {prop.Owner.Surname.Substring(0, 2)}***")
                ).ReverseMap();
            CreateMap<PetCreateDTO, Pet>()
                .ForMember(
                    src => src.Activities, opt => opt.Ignore()
                );
        }
    }
}
