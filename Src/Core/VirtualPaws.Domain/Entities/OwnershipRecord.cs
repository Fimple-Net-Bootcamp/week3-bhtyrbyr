using VirtualPaws.Domain.Common;

namespace VirtualPaws.Domain.Entities
{
    /// <summary>
    /// This entity was created to keep records of pet adoptions.
    /// </summary>
    public class OwnershipRecord : BaseEntity
    {
        /// <summary>
        /// Indicates the user who owns the pet.
        /// </summary>
        public User Owner { get; set; }

        /// <summary>
        /// Indicates which pet is owned.
        /// </summary>
        public Pet Pet { get; set; }

        /// <summary>
        /// Indicates the life status of the adopted pet.
        /// true = alive, false = not alive
        /// </summary>
        public bool PawStatus { get; set; } 
    }
}
