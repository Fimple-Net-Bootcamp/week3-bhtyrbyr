using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPaws.Domain.Common;

namespace VirtualPaws.Domain.Entities
{
    /// <summary>
    /// This entity was created to keep track of activities that pets can do.
    /// </summary>
    public class Activitie : BaseEntity
    {
        /// <summary>
        /// Specifies the name of the activity.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Indicates the pet that can do the activity.
        /// </summary>
        public List<Pet> Paws { get; set; }

        /// <summary>
        /// Indicates how much this activity will contribute to your health score.
        /// It can take a maximum value of 15.
        /// </summary>
        public byte NutritionalValue { get; set; }  
    }
}
