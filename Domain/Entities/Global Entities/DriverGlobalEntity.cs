using Domain.Common.CommonEntities;
using Domain.Entities.SystemEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Global_Entities
{
    public class DriverGlobalEntity : CloneableBaseEntity
    {
        [Key]
        public uint Driver_ID { get; set; }
        public byte Age { get; set; }
        public string DrivingLicence { get; set; }

        public ICollection<DriverDropedRiderSystemEntity> DriverDropedRiderSystemEntity { get; set; }
    }
}
