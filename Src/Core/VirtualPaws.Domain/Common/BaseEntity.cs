namespace VirtualPaws.Domain.Common
{
    /// <summary>
    /// Base is an abstract class. Holds creation date and id information of records.
    /// </summary>
    public abstract class BaseEntity
    {
        public UInt16 Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
