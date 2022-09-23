using Domain.Common.CommonEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.SystemEntities
{
    public sealed class DriverSystemEntity : AuditableBaseEntity
    {
        [Key]
        public uint Driver_ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public byte Age { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
        public string DrivingLicence { get; set; }

        public ICollection<DriverDropedRiderSystemEntity> Droped { get; set; }
    }
}
