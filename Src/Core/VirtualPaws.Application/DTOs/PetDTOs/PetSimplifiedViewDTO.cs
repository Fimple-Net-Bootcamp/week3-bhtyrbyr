using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPaws.Application.DTOs.PetDTOs
{
    public class PetSimplifiedViewDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string OwnerName { get; set; }
        public byte Level { get; set; }
        public byte XP { get; set; }
    }
}
