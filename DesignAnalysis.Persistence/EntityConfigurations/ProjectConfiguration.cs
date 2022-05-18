using DesignAnalysis.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Persistence.EntityConfigurations
{
    public class ProjectConfiguration : ConfigurationBase<Project, long>
    {
        protected override string PrimaryKeyName => "PK_Projects";

        public override void Configure(EntityTypeBuilder<Project> builder)
        {
            base.Configure(builder);
            builder.HasOne(e => e.Company)
                .WithOne(e => e.Project)
                .HasForeignKey<Project>(e => e.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Project_Company");
        }
    }
}
