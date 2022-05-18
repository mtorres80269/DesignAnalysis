using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Core.Entities
{
    public interface IAuditableEntity : IEntity
    {
        int CreatedById { get; set; }
        string CreatedBy { get; set; }
        long CreatedUnixTime { get; set; }
        int? UpdatedById { get; set; }
        string UpdatedBy { get; set; }
        long? UpdatedUnixTime { get; set; }
        int? DeletedById { get; set; }
        string DeletedBy { get; set; }
        long? DeletedUnixTime { get; set; }
    }
}
