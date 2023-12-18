using System.ComponentModel.DataAnnotations.Schema;
using VirtualPaws.Domain.Common;

namespace VirtualPaws.Domain.Entities
{
    /// <summary>
    /// This entity represents the state of health of pets.
    /// </summary>
    public class PetHealtStatus : BaseEntity
    {

        /// <summary>
        /// Indicates the which pet has a health record
        /// </summary>
        public UInt16 PetId { get; set; }
        /// <summary>
        /// Identifies which pet it is.
        /// </summary>
        [ForeignKey("PetId")]
        public Pet Pet { get; set; }

        /// <summary>
        /// Shows health status as a point system.
        /// A value of 100 is the maximum value and means healthy.
        /// A value of 0 means unhealthy (dead).
        /// </summary>
        public byte HealtScore { get; set; }
    }    
}
