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
    public class WeeklyReportConfiguration : IEntityTypeConfiguration<WeeklyReport>
    {
        public void Configure(EntityTypeBuilder<WeeklyReport> builder)
        {
            // Configure base properties (Id, CreatedAt, UpdatedAt, CreatedBy, UpdatedBy, IsDeleted)
            BaseEntityConfiguration.ConfigureBaseEntity(builder);

            builder.ToTable("WeeklyReports");

            // Entity-specific properties
            builder.Property(wr => wr.Title)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(wr => wr.Description)
                .IsRequired()
                .HasMaxLength(2000);

            builder.Property(wr => wr.FilePath)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(wr => wr.IsGeoValidated)
                .IsRequired()
                .HasDefaultValue(false);

            // Owned Value Object
            builder.OwnsOne(wr => wr.SubmissionLocation, location =>
            {
                location.Property(l => l.Latitude)
                    .HasColumnName("SubmissionLatitude")
                    .HasPrecision(18, 15);

                location.Property(l => l.Longitude)
                    .HasColumnName("SubmissionLongitude")
                    .HasPrecision(18, 15);

                location.Property(l => l.RadiusInMeters)
                    .HasColumnName("SubmissionRadiusInMeters");
            });

            // Indexes
            builder.HasIndex(wr => wr.ProjectId);
            builder.HasIndex(wr => wr.CreatedBy);
            builder.HasIndex(wr => wr.CreatedAt);
            builder.HasIndex(wr => wr.IsGeoValidated);
            builder.HasIndex(wr => wr.FilePath);
            builder.HasIndex(wr => new { wr.ProjectId, wr.CreatedAt });
            builder.HasIndex(wr => new { wr.ProjectId, wr.IsGeoValidated });
            builder.HasIndex(wr => new { wr.CreatedAt, wr.ProjectId });

            // Relationships
            builder.HasOne(wr => wr.Project)
                .WithMany(p => p.WeeklyReports)
                .HasForeignKey(wr => wr.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(wr => wr.CreatedByUser)
                .WithMany(u => u.CreatedReports)
                .HasForeignKey(wr => wr.CreatedBy)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
