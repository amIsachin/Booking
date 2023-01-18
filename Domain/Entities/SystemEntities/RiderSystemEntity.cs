﻿using Domain.Common.CommonEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.SystemEntities
{
    /// <summary>
    /// This entity is system entity please dont use for global application.
    /// this Enitty use only main service which store data in the database. not any other service.
    /// </summary>
    public sealed class RiderSystemEntity : CloneableBaseEntity
    {
        [Key]
        public int Rider_ID { get; set; }

        public ICollection<DriverDropedRiderSystemEntity> DriverDropedRiderSystemEntity { get; set; }
    }
}