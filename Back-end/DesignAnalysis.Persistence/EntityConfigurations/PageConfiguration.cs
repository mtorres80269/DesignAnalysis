using DesignAnalysis.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Persistence.EntityConfigurations
{
    public class PageConfiguration : ConfigurationBase<Page, int>
    {
        protected override string PrimaryKeyName => "PK_Page";
    }
}
