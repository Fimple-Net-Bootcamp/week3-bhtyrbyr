using System.ComponentModel.DataAnnotations.Schema;
using VirtualPaws.Domain.Common;

namespace VirtualPaws.Domain.Entities
{
    /// <summary>
    /// This entity specifies the characteristics of the paws registered in the system.
    /// </summary>
    public class Pet : BaseEntity
    {
        /// <summary>
        /// Indicates the pet's name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Indicates the Animal Type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Indicates the user who adopted the pet.
        /// </summary>
        public UInt16 OwnerId { get; set; }

        /// <summary>
        /// Indicates the user who adopted the pet.
        /// </summary>
        [ForeignKey("OwnerId")]
        public User Owner{ get; set; }

        /// <summary>
        /// Indicates the level of the pet.
        /// </summary>
        public byte Level { get; set; }

        /// <summary>
        /// Indicates the experience points of the current level of the pet.
        /// </summary>
        public byte XP { get; set; }

        /// <summary>
        /// Identifies activities that the pet can do.
        /// </summary>
        public List<Activity> Activities { get; set; }

        /// <summary>
        ///  Indicates how hungry the pet is.
        ///  - The weighted coefficient determining the value is the pet type.
        ///  - It takes a value between 1 and 100.
        ///  - Health scores are calculated based on hunger status and pet type.
        ///  - The lower the starvation, the more health points are reduced.
        /// </summary>
        public byte HungerScore { get; set; }       
    }
}
