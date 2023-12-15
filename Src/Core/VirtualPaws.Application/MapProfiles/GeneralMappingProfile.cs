using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPaws.Application.DTO_s.PetDTO_s;
using VirtualPaws.Domain.Entities;

namespace VirtualPaws.Application.MapProfiles
{
    public class GeneralMappingProfile : Profile
    {
        public GeneralMappingProfile()
        {
            CreateMap<Pet, PetSimplifiedViewDTO>();
        }
    }
}
