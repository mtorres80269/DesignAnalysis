using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Core.Entities
{
    public class ProjectStage: EntityBase<int>
    {
        public string ProjectStageName { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
