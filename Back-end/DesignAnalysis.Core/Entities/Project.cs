using System;
using System.Collections.Generic;
using System.Text;
using static DesignAnalysis.Core.Enums.Enums;

namespace DesignAnalysis.Core.Entities
{
    public class Project: AuditableEntityBase<long>
    {
        public string ProjectName { get; set; }
        public string Location { get; set; }
        public string ClientName { get; set; }
        public string Revision { get; set; }
        public string SystemName { get; set; }
        public long CompanyId { get; set; }
        public long EngineerDetailsId { get; set; }
        public int ProjectStageId { get; set; }
        public int ProjectStatusId { get; set; }
        public Company Company { get; set; }
        public EngineerDetail EngineerDetail { get; set; }
        public ICollection<Occupant> Occupants { get; set; }
        public ProjectStage ProjectStage { get; set; }
        public ProjectStatus ProjectStatus { get; set; }

    }
}
