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
        public ProjectStatus Status { get; set; }
        public string Revision { get; set; }
        public ProjectStage Stage { get; set; }
        public string SystemName { get; set; }
        public long CompanyId { get; set; }
        public long EngineerDetailsId { get; set; }
        public Company Company { get; set; }
        public EngineerDetail EngineerDetail { get; set; }
    }
}
