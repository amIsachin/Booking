using Domain.Common.CommonEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.SystemEntities
{
    public sealed class RiderSystemEntity : AuditableBaseEntity
    {
        [Key]
        public uint Rider_ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }

        public ICollection<DriverDropedRiderSystemEntity> Droped { get; set; }
    }
}