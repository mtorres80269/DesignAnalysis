using DesignAnalysis.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Persistence.EntityConfigurations
{
    public class UserConfiguration: ConfigurationBase<User, int>
    {
        protected override string PrimaryKeyName => "PK_User";
    }
}
