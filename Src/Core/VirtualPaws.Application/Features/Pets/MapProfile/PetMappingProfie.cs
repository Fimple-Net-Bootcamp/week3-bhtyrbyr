using AutoMapper;
using VirtualPaws.Application.DTO_s.PetDTO_s;
using VirtualPaws.Domain.Entities;

namespace VirtualPaws.Application.Features.Pets.MapProfile
{
    internal class PetMappingProfie : Profile
    {
        public PetMappingProfie()
        {
            CreateMap<Pet, PetSimplifiedViewDTO>()
                .ForMember(
                    src => src.PetType, opt =>
                    opt.MapFrom(

                            prop => Enum.GetName(typeof(PetTypeName), prop.PetType)
                        )
                );
            CreateMap<Pet, PetDetailedViewDTO>()
                .ForMember(
                    src => src.OwnerName, opt =>
                    opt.MapFrom(prop => prop.Owner.Name + " " + prop.Owner.Surname.Substring(0, 2) + "****")
                )
                .ForMember(
                    src => src.PetType, opt =>
                    opt.MapFrom(

                            prop => Enum.GetName(typeof(PetTypeName), prop.PetType)
                        )
                );
            CreateMap<PetCreateDTO, Pet>()
                .ForMember(
                    opt => opt.PetType, opt =>
                    opt.MapFrom(
                            prop => (byte)((PetTypeName)Enum.Parse(typeof(PetTypeName), prop.PetTypeName))
                        )
                );
        }
    }
}
