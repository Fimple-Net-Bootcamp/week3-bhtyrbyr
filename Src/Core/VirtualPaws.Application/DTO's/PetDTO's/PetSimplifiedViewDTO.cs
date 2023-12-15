namespace VirtualPaws.Application.DTO_s.PetDTO_s
{
    public class PetSimplifiedViewDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte PetType { get; set; }
        public bool IsAlive { get; set; }
        public bool IsOwned { get; set; }
    }
}
