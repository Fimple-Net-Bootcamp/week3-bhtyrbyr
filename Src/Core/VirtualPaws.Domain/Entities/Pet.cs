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
        /// Indicates the user who adopted the pet.
        /// </summary>
        public int? OwnerId { get; set; }

        /// <summary>
        /// Indicates the user who adopted the pet.
        /// </summary>
        [ForeignKey("OwnerId")]
        public User? Owner{ get; set; }

        /// <summary>
        /// Indicates when the pet was owned.
        /// </summary>
        public DateTime? OwnershipDate { get; set; }

        /// <summary>
        /// Identifies activities that the pet can do.
        /// </summary>
        public List<Activity> ActivitiesCanBe { get; set; }

        /// <summary>
        /// Specifies the type of the pet.
        /// - Can take a value between 1 and 10.
        /// - Users can adopt a pet based on this type value and their own X score.
        /// - 1 means puppy.
        /// - 10 means legendary.
        /// </summary>
        public byte PetType { get; set; }

        /// <summary>
        ///  Indicates how hungry the pet is.
        ///  - The weighted coefficient determining the value is the pet type.
        ///  - It takes a value between 1 and 100.
        ///  - Health scores are calculated based on hunger status and pet type.
        ///  - The lower the starvation, the more health points are reduced.
        /// </summary>
        public byte HungerStatus { get; set; }

        /// <summary>
        /// Indicates whether the pet is adopted or not.
        /// </summary>
        public bool IsOwned { get; set; }

        /// <summary>
        /// Indicates whether the pet is alive or not.
        /// </summary>
        public bool IsAlive { get; set; }

        /// <summary>
        /// Indicates whether the pet is visible or not.
        /// </summary>
        public bool IsVisible { get; set; }             
    }
}
