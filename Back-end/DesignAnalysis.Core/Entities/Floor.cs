using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Core.Entities
{
    public class Floor: EntityBase<int>
    {
        public string FloorName { get; set; }
        public ICollection<Occupant> Occupants { get; set; }
    }
}
