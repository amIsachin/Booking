namespace Domain.Common.CommonEntities
{
    public abstract class CombinationBaseEntity : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
    }
}
