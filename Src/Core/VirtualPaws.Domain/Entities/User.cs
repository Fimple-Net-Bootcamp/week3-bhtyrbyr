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
        /// Indicates the user name.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Specifies the user's password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Indicates the pets the user owns.
        /// </summary>
        public List<Pet> Pets { get; set; }

        /// <summary>
        /// Indicates whether the user account is active or not.
        /// </summary>
        public bool IsActive { get; set; }                  
    }
}
