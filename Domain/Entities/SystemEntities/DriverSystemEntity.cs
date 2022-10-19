using Domain.Common.CommonEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.SystemEntities
{
    /// <summary>
    /// This entity is system entity please dont use for global application.
    /// this Enitty use only main service which store data in the database. not any other service.
    /// </summary>
    public sealed class DriverSystemEntity : CloneableBaseEntity
    {
        [Key]
        public uint Driver_ID { get; set; }
        public byte Age { get; set; }
        public string DrivingLicence { get; set; }

        public ICollection<DriverDropedRiderSystemEntity> DriverDropedRiderSystemEntity { get; set; }
    }
}
