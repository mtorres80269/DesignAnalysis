using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Core.Entities
{
    public class Facility: EntityBase<int>
    {
        public string FacilityName { get; set; }
        public string OccupantLoad { get; set; }
        public string Area { get; set; }
        public string Calculation { get; set; }
        public string UnitOfMeasurement { get; set; }
        public ICollection<BuildingFacility> BuildingFacilities { get; set; }
        public ICollection<Occupant> Occupants { get; set; }
    }
}
