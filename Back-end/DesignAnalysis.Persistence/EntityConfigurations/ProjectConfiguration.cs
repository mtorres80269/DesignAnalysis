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
                .WithMany(e => e.Projects)
                .HasForeignKey(e => e.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Project_Company");

            builder.HasOne(e => e.EngineerDetail)
                .WithMany(e => e.Projects)
                .HasForeignKey(e => e.EngineerDetailsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Project_EngineerDetail");

            builder.HasOne(e => e.ProjectStage)
               .WithMany(e => e.Projects)
               .HasForeignKey(e => e.ProjectStageId)
               .OnDelete(DeleteBehavior.ClientSetNull)
               .HasConstraintName("FK_Project_ProjectStage");

            builder.HasOne(e => e.ProjectStatus)
             .WithMany(e => e.Projects)
             .HasForeignKey(e => e.ProjectStatusId)
             .OnDelete(DeleteBehavior.ClientSetNull)
             .HasConstraintName("FK_Project_ProjectStatus");
        }
    }
}
