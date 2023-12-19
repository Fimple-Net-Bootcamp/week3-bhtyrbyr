using System.ComponentModel.DataAnnotations.Schema;
using VirtualPaws.Domain.Common;
using VirtualPaws.Domain.Entities;

namespace VirtualPaws.Domain.RecordEntities
{
    public class FeedRecord : BaseRecordEntity
    {
        public UInt16 FoodId { get; set; }
        [ForeignKey("FoodId")]
        public PetFood Food { get; set; }
    }
}
