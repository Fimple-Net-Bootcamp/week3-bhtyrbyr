using VirtualPaws.Domain.Common;

namespace VirtualPaws.Domain.Entities
{
    public class Training : BaseEntity
    {
        /// <summary>
        /// Specifies the name of the training.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Indicates the contribution to the level.
        /// </summary>
        public byte XP { get; set; }
    }
}
