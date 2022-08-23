using System;

namespace Domain.Common
{
    public abstract class AuditableBaseEntity : BaseEntity
    {
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; }


        public int ID { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}