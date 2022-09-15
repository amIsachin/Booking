using Domain.Common;

namespace Domain.Entities
{
    internal sealed class RiderEntity : AuditableBaseEntity
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }
}