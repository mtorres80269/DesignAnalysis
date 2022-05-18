using DesignAnalysis.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Persistence.EntityConfigurations
{
    public class CompanyConfiguration : ConfigurationBase<Company, long>
    {
        protected override string PrimaryKeyName => "PK_Companies";

        public override void Configure(EntityTypeBuilder<Company> builder)
        {
            base.Configure(builder);
        }
    }
}
