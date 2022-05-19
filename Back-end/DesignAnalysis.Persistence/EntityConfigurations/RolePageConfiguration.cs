using DesignAnalysis.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Persistence.EntityConfigurations
{
    public class RolePageConfiguration : ConfigurationBase<RolePage, int>
    {
        protected override string PrimaryKeyName => "PK_Role_Page";

        public override void Configure(EntityTypeBuilder<RolePage> builder)
        {
            base.Configure(builder);

            builder.HasOne(e => e.Role)
                .WithMany(e => e.RolePages)
                .HasForeignKey(e => e.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RolePage_Role");

            builder.HasOne(e => e.Page)
                .WithMany(e => e.RolePages)
                .HasForeignKey(e => e.PageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RolePage_Page");
        }
    }
}
