﻿using Domain.Common;

namespace Domain.Entities.SystemEntities
{
    public sealed class RiderSystemEntity : AuditableBaseEntity
    {
        public uint Rider_ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
    }
}