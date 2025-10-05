using DEM_DAR.Models;

using DEM_DAR.Models.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee = DEM_DAR.Models.Employee;

namespace DEM_DAR.Context.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.Name).IsRequired()
                .HasColumnType("varChar")
                .HasMaxLength(20);
            //builder.Property(e => e.Image).IsRequired()
            //  .HasColumnType("varChar")
            //  .HasMaxLength(256);

            builder.Property(e => e.Adress).IsRequired()
             .HasColumnType("varChar")
             .HasMaxLength(30);

            builder.Property(e => e.Salary).IsRequired()
             .HasColumnType("varChar")
             .HasMaxLength(20);

            builder.Property(e => e.Email).IsRequired(false)
             .HasColumnType("varChar")
             .HasMaxLength(20);

            builder.Property(e => e.Phone).IsRequired(false)
            .HasColumnType("varChar")
            .HasMaxLength(20);


            builder.Property(e => e.Gender)
        .IsRequired()
        .HasConversion(
            x => x.ToString(),
            s => Enum.Parse<Gender>(s)
        );

            builder.Property(e => e.employeeType)
                   .IsRequired()
                   .HasConversion(
                       x => x.ToString(),
                       s => Enum.Parse<EmployeeType>(s)
                   );


        }
    }
}
