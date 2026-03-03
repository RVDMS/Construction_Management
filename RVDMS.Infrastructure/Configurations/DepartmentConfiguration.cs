using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");

            // Configure BaseEntity properties
            BaseEntityConfiguration.ConfigureBaseEntity(builder);

            builder.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(d => d.Code)
                .HasMaxLength(50);

            builder.Property(d => d.Description)
                .HasMaxLength(500);

            // Indexes
            builder.HasIndex(d => d.Code).IsUnique();

            
           
        }
    }
    }

