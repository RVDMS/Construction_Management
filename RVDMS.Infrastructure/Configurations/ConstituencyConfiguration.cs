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
    public class ConstituencyConfiguration : IEntityTypeConfiguration<Constituency>
    {
        public void Configure(EntityTypeBuilder<Constituency> builder)
        {
            builder.ToTable("Constituencies");

            // Configure BaseEntity properties
            BaseEntityConfiguration.ConfigureBaseEntity(builder);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.Code)
                .HasMaxLength(50);

            // Indexes
            builder.HasIndex(c => c.Code).IsUnique();
            builder.HasIndex(c => c.CountyId);

            // Relationships
            builder.HasOne(c => c.County)
                .WithMany(c => c.Constituencies)
                .HasForeignKey(c => c.CountyId)
                .OnDelete(DeleteBehavior.Restrict);

           
        }
    }
}
