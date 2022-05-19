using DesignAnalysis.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Persistence.EntityConfigurations
{
    public class FloorConfiguration : ConfigurationBase<Floor, int>
    {
        protected override string PrimaryKeyName => "PK_Floor";
    }
}
