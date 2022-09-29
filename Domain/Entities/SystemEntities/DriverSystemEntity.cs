using Domain.Common.CommonEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.SystemEntities
{
    public sealed class DriverSystemEntity : CloneableBaseEntity
    {
        [Key]
        public uint Driver_ID { get; set; }
        public byte Age { get; set; }
        public string DrivingLicence { get; set; }

        public ICollection<DriverDropedRiderSystemEntity> Droped { get; set; }
    }
}
