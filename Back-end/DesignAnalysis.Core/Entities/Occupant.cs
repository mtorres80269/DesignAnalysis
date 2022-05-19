using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Core.Entities
{
    public class Occupant: EntityBase<int>
    {
        public long ProjectId { get; set; }
        public int BuildingId { get; set; }
        public int FacilityId { get; set; }
        public int FloorId { get; set; }
        public int OccupantCount { get; set; }
        public Project Project { get; set; }
        public Building Building { get; set; }
        public Facility Facility { get; set; }
        public Floor Floor { get; set; }
    }
}
