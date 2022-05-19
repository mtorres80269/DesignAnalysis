using DesignAnalysis.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Persistence.EntityConfigurations
{
    public class OccupantConfiguration: ConfigurationBase<Occupant, int>
    {
        protected override string PrimaryKeyName => "PK_Occupant";

        public override void Configure(EntityTypeBuilder<Occupant> builder)
        {
            base.Configure(builder);

            builder.HasOne(e => e.Project)
                .WithMany(e => e.Occupants)
                .HasForeignKey(e => e.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Occupant_Project");

            builder.HasOne(e => e.Building)
                .WithMany(e => e.Occupants)
                .HasForeignKey(e => e.BuildingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Occupant_Building");

            builder.HasOne(e => e.Facility)
               .WithMany(e => e.Occupants)
               .HasForeignKey(e => e.FacilityId)
               .OnDelete(DeleteBehavior.ClientSetNull)
               .HasConstraintName("FK_Occupant_Facility");

            builder.HasOne(e => e.Floor)
              .WithMany(e => e.Occupants)
              .HasForeignKey(e => e.FloorId)
              .OnDelete(DeleteBehavior.ClientSetNull)
              .HasConstraintName("FK_Occupant_Floor");
        }
    }
}
