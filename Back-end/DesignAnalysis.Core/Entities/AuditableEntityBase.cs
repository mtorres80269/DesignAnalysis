using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Core.Entities
{
    public abstract class AuditableEntityBase<TIdentifier>: EntityBase<TIdentifier>, IAuditableEntity
    {
        public int CreatedById { get; set; }
        public string CreatedBy { get; set; }
        public long CreatedUnixTime { get; set; }
        public int? UpdatedById { get; set; }
        public string UpdatedBy { get; set; }
        public long? UpdatedUnixTime { get; set; }
        public int? DeletedById { get; set; }
        public string DeletedBy { get; set; }
        public long? DeletedUnixTime { get; set; }
    }
}
