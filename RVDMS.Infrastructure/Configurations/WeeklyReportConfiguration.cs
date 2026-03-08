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
            builder.ToTable("WeeklyReports");

            

            // Property configurations
            builder.Property(wr => wr.Title)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(wr => wr.Description)
                .IsRequired()
                .HasMaxLength(2000);

            builder.Property(wr => wr.WeekNumber)
                .IsRequired();

            builder.Property(wr => wr.Year)
                .IsRequired();

            builder.Property(wr => wr.ReportedProgress)
                .HasPrecision(5, 2)
                .IsRequired();

            builder.Property(wr => wr.Challenges)
                .HasMaxLength(2000);

            builder.Property(wr => wr.NextWeekPlan)
                .HasMaxLength(2000);

            builder.Property(wr => wr.FilePath)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(wr => wr.IsGeoValidated)
                .IsRequired()
                .HasDefaultValue(false);

            // Owned entity configuration for SubmissionLocation (Value Object)
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

                // Optional: Add index on location for spatial queries
                // Note: For SQL Server, you might want to add a spatial index
            });

            // Indexes for performance
            builder.HasIndex(wr => wr.ProjectId);
            builder.HasIndex(wr => wr.CreatedBy);
            builder.HasIndex(wr => wr.CreatedAt);
            builder.HasIndex(wr => wr.WeekNumber);
            builder.HasIndex(wr => wr.Year);
            builder.HasIndex(wr => wr.IsGeoValidated);
            builder.HasIndex(wr => wr.FilePath);

            // Unique constraint: Only one report per project per week
            builder.HasIndex(wr => new { wr.ProjectId, wr.Year, wr.WeekNumber })
                .IsUnique()
                .HasFilter("[IsDeleted] = 0"); // Only enforce on non-deleted records

            // Composite indexes for common query patterns
            builder.HasIndex(wr => new { wr.ProjectId, wr.CreatedAt });
            builder.HasIndex(wr => new { wr.ProjectId, wr.IsGeoValidated });
            builder.HasIndex(wr => new { wr.Year, wr.WeekNumber, wr.ProjectId });

            // Index for finding reports by date range
            builder.HasIndex(wr => new { wr.CreatedAt, wr.ProjectId });

            // Relationships
            builder.HasOne(wr => wr.Project)
                .WithMany(p => p.WeeklyReports)
                .HasForeignKey(wr => wr.ProjectId)
                .OnDelete(DeleteBehavior.Cascade); // If project is deleted, delete its reports

            // Relationship with the user who created the report (CreatedBy from BaseEntity)
            builder.HasOne<ApplicationUser>()
                .WithMany(u => u.CreatedReports)
                .HasForeignKey(wr => wr.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict); // Don't delete reports if user is deleted

            // Check constraints for data validation
            builder.ToTable(t => t.HasCheckConstraint("CK_WeeklyReport_WeekNumber_Range",
                "WeekNumber >= 1 AND WeekNumber <= 53"));

            builder.ToTable(t => t.HasCheckConstraint("CK_WeeklyReport_Year_Range",
                "Year >= 2000 AND Year <= 2100"));

            builder.ToTable(t => t.HasCheckConstraint("CK_WeeklyReport_ReportedProgress_Range",
                "ReportedProgress >= 0 AND ReportedProgress <= 100"));

            // Optional: Computed column for report period (if needed)
            // builder.Property(wr => wr.ReportPeriod)
            //     .HasComputedColumnSql("CONCAT(Year, '-W', FORMAT(WeekNumber, 'D2'))", stored: false);

            // Filter for soft delete (already in BaseEntityConfiguration, but can be overridden)
            builder.HasQueryFilter(wr => !wr.IsDeleted);
        }
    }
}
