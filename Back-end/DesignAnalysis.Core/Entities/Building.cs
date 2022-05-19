using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Core.Entities
{
    public class Building: EntityBase<int>
    {
        public string BuildingName { get; set; }
        public ICollection<BuildingFacility> BuildingFacilities { get; set; }
        public ICollection<Occupant> Occupants { get; set; }
    }
}
