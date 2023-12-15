using VirtualPaws.Domain.Common;

namespace VirtualPaws.Domain.Entities
{
    /// <summary>
    /// This entity represents the users registered in the system.
    /// </summary>
    public class User : BaseEntity
    {

        /// <summary>
        /// Specifies the name of the user.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Specifies the user's surname.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Specifies the user's password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Specifies the user's birthday.
        /// </summary>
        public DateTime BirthDay { get; set; }

        /// <summary>
        /// Indicates the user's ability to adopt a pet.  
        /// - The starting score is 1. 
        /// - The maximum score is 100. 
        /// - Determines how many pets the user can have at the same time (1 more than the score divided by 10).
        /// </summary>
        public byte PetOwnershipAbility { get; set; }

        /// <summary>
        /// Indicates the pets the user owns.
        /// </summary>
        public List<Pet> Paws { get; set; }

        /// <summary>
        /// Indicates whether the user account is active or not.
        /// </summary>
        public bool IsActive { get; set; }                  
    }
}
