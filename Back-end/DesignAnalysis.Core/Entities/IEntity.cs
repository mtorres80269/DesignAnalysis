using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Core.Entities
{
    public interface IEntity
    {

    }
    public interface IEntity<TIdentifier>: IEntity
    {
        TIdentifier Id { get; set; }
    }
}
