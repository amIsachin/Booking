using Domain.Common.CommonEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.SystemEntities
{
    public sealed class RiderSystemEntity : CloneableBaseEntity
    {
        [Key]
        public uint Rider_ID { get; set; }

        public ICollection<DriverDropedRiderSystemEntity> DriverDropedRiderSystemEntity { get; set; }
    }
}