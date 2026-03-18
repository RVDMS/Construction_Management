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
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            {
                builder.ToTable("Users");

                builder.Property(u => u.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property(u => u.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property(u => u.CreatedAt)
                    .IsRequired()
                    .HasDefaultValueSql("GETUTCDATE()");

                // Owned entity configuration for Location
                builder.OwnsOne(u => u.BaseLocation, location =>
                {
                    location.Property(l => l.Latitude)
                        .HasColumnName("BaseLatitude")
                        .HasPrecision(9, 6)
                        .IsRequired();

                    location.Property(l => l.Longitude)
                        .HasColumnName("BaseLongitude")
                        .HasPrecision(9, 6)
                        .IsRequired();

                    location.Property(l => l.RadiusInMeters)
                        .HasColumnName("BaseRadiusInMeters")
                        .IsRequired();
                });

                // Indexes
                builder.HasIndex(u => u.IsActive);
                builder.HasIndex(u => u.LastLoginAt);
                builder.HasIndex(u => new { u.FirstName, u.LastName });

                // Relationships
                

                builder.HasMany(u => u.LedProjects)
                    .WithOne(p => p.ProjectLead)
                    .HasForeignKey(p => p.ProjectLeadId)
                    .OnDelete(DeleteBehavior.SetNull);
            }
        }
    }
}
