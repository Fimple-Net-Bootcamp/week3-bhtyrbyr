using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPaws.Application.DTOs.PetDTOs
{
    public class PetCreateDTO
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public List<string> Activities { get; set; }
    }
}
