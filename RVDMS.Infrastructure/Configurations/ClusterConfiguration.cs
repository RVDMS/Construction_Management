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
    public class ClusterConfiguration : IEntityTypeConfiguration<Cluster>
    {
        public void Configure(EntityTypeBuilder<Cluster> builder)
        {
            builder.ToTable("Clusters");

            

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.Code)
                .HasMaxLength(50);

            // Indexes
            builder.HasIndex(c => c.Code).IsUnique();
            builder.HasIndex(c => c.DepartmentId);

            // Relationships
            builder.HasOne(c => c.Department)
                .WithMany(d => d.Clusters)
                .HasForeignKey(c => c.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            
        }
    }
}
