using ByConvention.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ByConvention.Confiurations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {

            builder.HasKey(D => D.Id);

            builder.Property(D => D.Id)
                            .UseIdentityColumn(10, 10);

                builder.Property(D => D.Name)
                            .HasColumnName("DepartmentName")
                            .HasColumnType("varchar")
                            .HasMaxLength(50)
                            .IsRequired(false)
                            .HasDefaultValue("Test Department");

                builder.Property(D => D.DateOfCreation)
                            .HasDefaultValueSql("getdate()");
           
        }
    }
}
