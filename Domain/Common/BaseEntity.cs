using System;

namespace Domain.Common
{
    public interface BaseEntity
    {
        int ID { get; set; }
        DateTime CreatedOn { get; set; }
    }
}
