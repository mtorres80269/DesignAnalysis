using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Core.Entities
{
    public class ProjectStatus: EntityBase<int>
    {
        public string ProjectStatusName { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
