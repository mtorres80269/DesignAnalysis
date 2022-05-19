using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Core.Entities
{
    public class BuildingFacility: EntityBase<int>
    {
        public int BuildingId { get; set; }
        public int FacilityId { get; set; }
        public Building Building { get; set; }
        public Facility Facility { get; set; }
    }
}
