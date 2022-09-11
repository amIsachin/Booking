using Domain.Common;

namespace Domain.Entities
{
    internal sealed class DriverEntity : AuditableBaseEntity
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public byte Age { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
        public string DrivingLicence { get; set; }
    }
}