using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPaws.Domain.Common;

namespace VirtualPaws.Domain.Entities
{
    /// <summary>
    /// This entity represents the state of health of pets.
    /// </summary>
    public class PetHealtStatus : BaseEntity
    {
        /// <summary>
        /// Identifies which pet it is.
        /// </summary>
        public Pet Pet { get; set; }

        /// <summary>
        /// Shows health status as a point system.
        /// A value of 100 is the maximum value and means healthy.
        /// A value of 0 means unhealthy (dead).
        /// </summary>
        public byte HealtScore { get; set; }
    }    
}
