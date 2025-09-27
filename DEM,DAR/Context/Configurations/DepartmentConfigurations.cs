using DEM_DAR.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM_DAR.Context.Configirations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(d => d.Name).IsRequired()
                .HasMaxLength(50).HasColumnType("varchar");
            builder.Property(d => d.Description).IsRequired()
                .HasMaxLength(50).HasColumnType("varchar");
            builder.Property(d => d.code).IsRequired()
                .HasMaxLength(50).HasColumnType("varchar");
            builder.Property(d => d.Kind).HasDefaultValueSql("GetDate");
             

        }
    }
}
