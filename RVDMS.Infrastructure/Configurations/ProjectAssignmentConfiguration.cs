using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RVDMS.Domain.Constants;
using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Configurations
{
    public class ProjectAssignmentConfiguration :IEntityTypeConfiguration<ProjectAssignment>
    {
        public void Configure(EntityTypeBuilder<ProjectAssignment> builder)
        {
            BaseEntityConfiguration.ConfigureBaseEntity(builder);

            builder.ToTable("ProjectAssignments");

            builder.Property(pa => pa.UserId)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(pa => pa.Role)
                .HasMaxLength(50);  // Not required? Made nullable in entity

            builder.Property(pa => pa.AssignedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            // Indexes
            builder.HasIndex(pa => new { pa.ProjectId, pa.UserId }).IsUnique();
            builder.HasIndex(pa => pa.UserId);
            builder.HasIndex(pa => pa.Role);
            builder.HasIndex(pa => pa.RevokedAt);

            // Composite index for finding active assignments
            builder.HasIndex(pa => new { pa.ProjectId, pa.Role, pa.RevokedAt })
                .HasFilter("[RevokedAt] IS NULL AND [Role] IS NOT NULL");

            // Ensure only one active COW per project
            builder.HasIndex(pa => new { pa.ProjectId, pa.Role })
                .IsUnique()
                .HasFilter($"[Role] = '{UserRoles.ClerkOfWorks}' AND [RevokedAt] IS NULL");

            // Relationships
            builder.HasOne(pa => pa.Project)
                .WithMany(p => p.ProjectAssignments)
                .HasForeignKey(pa => pa.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(pa => pa.User)
                .WithMany(u => u.ProjectAssignments)
                .HasForeignKey(pa => pa.UserId)
                
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
