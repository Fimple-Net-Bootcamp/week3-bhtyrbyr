namespace VirtualPaws.Domain.Common
{
    /// <summary>
    /// Base is an abstract class. Holds creation date and id information of records.
    /// </summary>
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
