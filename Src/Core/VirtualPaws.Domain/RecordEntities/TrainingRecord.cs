using System.ComponentModel.DataAnnotations.Schema;
using VirtualPaws.Domain.Common;
using VirtualPaws.Domain.Entities;

namespace VirtualPaws.Domain.RecordEntities
{
    public class TrainingRecord : BaseRecordEntity
    {
        public UInt16 TrainingId { get; set; }
        [ForeignKey("TrainingId")]
        public Training Training { get; set; }
    }
}
