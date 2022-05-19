using DesignAnalysis.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Persistence.EntityConfigurations
{
    public class ProjectStageConfiguration : ConfigurationBase<ProjectStage, int>
    {
        protected override string PrimaryKeyName => "PK_Project_Stage";
    }
}
