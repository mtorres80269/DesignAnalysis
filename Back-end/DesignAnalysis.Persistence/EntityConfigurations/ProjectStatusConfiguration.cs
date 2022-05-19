using DesignAnalysis.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Persistence.EntityConfigurations
{
    public class ProjectStatusConfiguration : ConfigurationBase<ProjectStatus, int>
    {
        protected override string PrimaryKeyName => "PK_Project_Status";
    }
}
