using Domain.Common.CommonEntities;
using Domain.Entities.SystemEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Global_Entities
{
    /// <summary>
    /// This entity is global entity you can use for global application.
    /// this Enitty use everywhere. not restriction for this entity.
    /// </summary>
    public class DriverGlobalEntity : CloneableBaseEntity
    {
        [Key]
        public uint Driver_ID { get; set; }
        public byte Age { get; set; }
        public string DrivingLicence { get; set; }

        public ICollection<DriverDropedRiderSystemEntity> DriverDropedRiderSystemEntity { get; set; }
    }
}
