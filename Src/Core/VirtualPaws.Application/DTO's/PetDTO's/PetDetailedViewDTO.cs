using VirtualPaws.Application.DTO_s.ActivitiyDTO_s;

namespace VirtualPaws.Application.DTO_s.PetDTO_s
{
    public class PetDetailedViewDTO
    {
        public string Name { get; set; }
        public string OwnerName { get; set; }
        public string OwnershipDate { get; set; }
        public string PetType { get; set; }
        public byte HungerStatus { get; set; }
        public List<ActivityViewDTO> Activities { get; set; }
        public bool IsOwned { get; set; }
        public bool IsAlive { get; set; }
        public bool IsVisible { get; set; }

    }
}
