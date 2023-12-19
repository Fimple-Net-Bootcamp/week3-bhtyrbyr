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
                )
                .ForMember(
                    src => src.Level, opt => opt.MapFrom(prop => 1)
                )
                .ForMember(
                    src => src.XP, opt => opt.MapFrom(prop => 1)
                )
                .ForMember(
                    src => src.HungerScore, opt => opt.MapFrom(prop => 100)
                )
                .ForMember(
                    src => src.CreateDate, opt => opt.MapFrom(prop => DateTime.Now.Date)
                )
                .ForMember(
                    src => src.UpdateDate, opt => opt.MapFrom(prop => DateTime.Now.Date)
                );
        }
    }
}
