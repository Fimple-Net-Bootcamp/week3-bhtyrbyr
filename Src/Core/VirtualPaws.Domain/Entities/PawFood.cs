using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPaws.Domain.Common;

namespace VirtualPaws.Domain.Entities
{
    /// <summary>
    /// This entity defines the food that pets can be fed.
    /// </summary>
    public class PawFood : BaseEntity
    {
        /// <summary>
        /// Specifies the name of the food.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Indicates how much this activity will contribute to your health score.
        /// It can take a maximum value of 25.
        /// </summary>
        public byte NutritionalValue { get; set; }      
    }
}
