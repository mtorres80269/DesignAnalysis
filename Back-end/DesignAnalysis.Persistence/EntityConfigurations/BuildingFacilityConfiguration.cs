using DesignAnalysis.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Persistence.EntityConfigurations
{
    public class BuildingFacilityConfiguration: ConfigurationBase<BuildingFacility, int>
    {
        protected override string PrimaryKeyName => "PK_Building_Facility";

        public override void Configure(EntityTypeBuilder<BuildingFacility> builder)
        {
            base.Configure(builder);

            builder.HasOne(e => e.Building)
                .WithMany(e => e.BuildingFacilities)
                .HasForeignKey(e => e.BuildingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Building_Facility_Building");

            builder.HasOne(e => e.Facility)
                .WithMany(e => e.BuildingFacilities)
                .HasForeignKey(e => e.FacilityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Building_Facility_Facility");
        }
    }
}
