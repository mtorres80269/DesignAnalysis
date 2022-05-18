using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Core.Entities
{
    public abstract class EntityBase<TIdentifier> : IEntity<TIdentifier>
    {
        public TIdentifier Id { get; set; }
    }
}
