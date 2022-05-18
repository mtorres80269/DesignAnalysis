using DesignAnalysis.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Persistence.EntityConfigurations
{
    public class EngineerDetailConfiguration : ConfigurationBase<EngineerDetail, long>
    {
        protected override string PrimaryKeyName => "PK_EngineerDetails";

        public override void Configure(EntityTypeBuilder<EngineerDetail> builder)
        {
            base.Configure(builder);
        }
    }
}
