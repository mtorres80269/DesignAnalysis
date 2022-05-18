using DesignAnalysis.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Persistence.EntityConfigurations
{
    public abstract class ConfigurationBase<TEntity, TIdentifier> : IEntityTypeConfiguration<TEntity>
        where TEntity : class, IEntity<TIdentifier>
    {
        protected abstract string PrimaryKeyName { get; }

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(e => e.Id)
                .HasName(PrimaryKeyName);

            if (typeof(TIdentifier) != typeof(Guid))
                builder.Property(e => e.Id)
                    .UseIdentityColumn();
        }
    }
}
