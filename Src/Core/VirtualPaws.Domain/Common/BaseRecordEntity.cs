using System.ComponentModel.DataAnnotations.Schema;
using VirtualPaws.Domain.Entities;

namespace VirtualPaws.Domain.Common
{
    public class BaseRecordEntity
    {
        public UInt16 Id { get; set; }
        public UInt16 OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public User Owner { get; set; }
        public UInt16 PetId { get; set; }
        [ForeignKey("PetId")]
        public Pet Pet { get; set; }
        public string Controller { get; set; }
        public DateTime Date { get; set; }

    }
}
