using System;

namespace Domain.Common
{
    /// <summary>
    /// This *(abstract class) is use only *(system entities).
    /// Because this class properties directed related to contain system information. which is direct affected by entire application.
    /// </summary>
    public abstract class AuditableBaseEntity
    {
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModified { get; set; }
        public string LastModifiedBy { get; set; }
    }
}