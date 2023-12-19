using System.ComponentModel.DataAnnotations.Schema;
using VirtualPaws.Domain.Common;
using VirtualPaws.Domain.Entities;

namespace VirtualPaws.Domain.RecordEntities
{
    public class ActivityRecord : BaseRecordEntity
    {
        public UInt16 ActivityId { get; set; }
        [ForeignKey("ActivityId")]
        public Activity Activity { get; set; }
    }
}
