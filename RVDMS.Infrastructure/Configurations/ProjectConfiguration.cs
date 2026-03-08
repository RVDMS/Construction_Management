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
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects");

            

            // Property configurations
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(p => p.TenderNumber)
                .HasMaxLength(100);

            builder.Property(p => p.ProjectLeadId)
                .HasMaxLength(450);

            builder.Property(p => p.ContractorName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.ConsultantName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.Description)
                .HasMaxLength(1000);

            builder.Property(p => p.ContractSum)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.Property(p => p.StartDate)
                .IsRequired();

            builder.Property(p => p.EndDate)
                .IsRequired();

            // Location properties
            builder.Property(p => p.Latitude)
                .HasPrecision(18, 15)
                .IsRequired();

            builder.Property(p => p.Longitude)
                .HasPrecision(18, 15)
                .IsRequired();

            builder.Property(p => p.RadiusInMeters)
                .IsRequired();

            // Progress tracking
            builder.Property(p => p.CurrentPhysicalProgress)
                .HasPrecision(5, 2)
                .IsRequired()
                .HasDefaultValue(0);

            builder.Property(p => p.LastProgressUpdate);

            builder.Property(p => p.LastUpdatedById)
                .HasMaxLength(450);

            // Status enum conversion
            builder.Property(p => p.Status)
                .HasConversion<string>()
                .HasMaxLength(50)
                .IsRequired();

            // Computed column for TimeElapsedPercentage (optional - can be kept as computed or ignored)
            builder.Property(p => p.TimeElapsedPercentage)
                .HasComputedColumnSql(@"
                    CAST(
                        CASE 
                            WHEN DATEDIFF(day, StartDate, EndDate) <= 0 THEN 0
                            WHEN DATEDIFF(day, StartDate, GETUTCDATE()) <= 0 THEN 0
                            WHEN DATEDIFF(day, StartDate, GETUTCDATE()) >= DATEDIFF(day, StartDate, EndDate) THEN 100
                            ELSE (DATEDIFF(day, StartDate, GETUTCDATE()) * 100.0) / DATEDIFF(day, StartDate, EndDate)
                        END AS DECIMAL(5,2))",
                    stored: false);

            // Indexes for performance
            builder.HasIndex(p => p.Name);
            builder.HasIndex(p => p.TenderNumber).IsUnique();
            builder.HasIndex(p => p.Status);
            builder.HasIndex(p => p.WardId);
            builder.HasIndex(p => p.ClusterId);
            builder.HasIndex(p => p.ProjectLeadId);
            builder.HasIndex(p => p.StartDate);
            builder.HasIndex(p => p.EndDate);
            builder.HasIndex(p => p.LastProgressUpdate);
            builder.HasIndex(p => p.ContractorName);
            builder.HasIndex(p => p.ConsultantName);

            // Composite indexes for common queries
            builder.HasIndex(p => new { p.Status, p.StartDate });
            builder.HasIndex(p => new { p.ClusterId, p.Status });
            builder.HasIndex(p => new { p.WardId, p.Status });

            // Relationships
            builder.HasOne(p => p.Ward)
                .WithMany(w => w.Projects)
                .HasForeignKey(p => p.WardId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Cluster)
                .WithMany(c => c.Projects)
                .HasForeignKey(p => p.ClusterId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(p => p.ProjectLead)
                .WithMany(u => u.LedProjects)
                .HasForeignKey(p => p.ProjectLeadId)
                .OnDelete(DeleteBehavior.SetNull);

            

            

            // Ignore computed properties not stored in DB
            builder.Ignore(p => p.Progress);
            builder.Ignore(p => p.TimeElapsedPercentage);

            // Check constraint for dates
            builder.ToTable(t => t.HasCheckConstraint("CK_Project_EndDateGreaterThanStartDate",
                "EndDate >= StartDate"));

            // Check constraint for physical progress
            builder.ToTable(t => t.HasCheckConstraint("CK_Project_CurrentPhysicalProgress_Range",
                "CurrentPhysicalProgress >= 0 AND CurrentPhysicalProgress <= 100"));

            // Check constraint for contract sum
            builder.ToTable(t => t.HasCheckConstraint("CK_Project_ContractSum_Positive",
                "ContractSum >= 0"));

            // Check constraint for radius
            builder.ToTable(t => t.HasCheckConstraint("CK_Project_RadiusInMeters_Positive",
                "RadiusInMeters >= 0"));
        }
    }
}
