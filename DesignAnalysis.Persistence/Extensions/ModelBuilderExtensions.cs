using DesignAnalysis.Common.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAnalysis.Persistence.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void UseMsSqlConvention(this ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.GetTableName().ToPascalCase());

                foreach (var property in entity.GetProperties())
                    property.SetColumnName(property.GetColumnName().ToPascalCase());

                foreach (var key in entity.GetKeys())
                    key.SetName(key.GetName().ToPascalCase());

                foreach (var key in entity.GetForeignKeys())
                    key.SetConstraintName(key.GetConstraintName().ToPascalCase());

                foreach (var index in entity.GetIndexes())
                    index.SetName(index.GetName().ToPascalCase());
            }
        }
    }
}
