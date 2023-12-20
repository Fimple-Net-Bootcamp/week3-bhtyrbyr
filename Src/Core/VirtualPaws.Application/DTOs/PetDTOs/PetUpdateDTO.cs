using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPaws.Application.DTOs.PetDTOs
{
    public class PetUpdateDTO
    {
        public string NewName { get; set; }
        public string NewType { get; set; }
        public byte NewLevel { get; set; }
        public byte NewXP { get; set; }
        public byte NewHungerScore { get; set; }
    }
}
