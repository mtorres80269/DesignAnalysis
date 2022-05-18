using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Core.Entities
{
    public class EngineerDetail: AuditableEntityBase<long>
    {
        public string Title { get; set; }
        public string RegNo { get; set; }
        public string PtrNo { get; set; }
        public string Tin { get; set; }
        public string IssueDate { get; set; }
        public string IssuedAt { get; set; }
    }
}
