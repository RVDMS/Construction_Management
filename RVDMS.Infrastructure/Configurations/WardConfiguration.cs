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
    public class WardConfiguration : IEntityTypeConfiguration<Ward>
    {
        public void Configure(EntityTypeBuilder<Ward> builder)
        {
            builder.ToTable("Wards");

            // Configure BaseEntity properties
            BaseEntityConfiguration.ConfigureBaseEntity(builder);

            // Property configurations
            builder.Property(w => w.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(w => w.Code)
                .HasMaxLength(50);

            // Indexes for performance
            builder.HasIndex(w => w.Name);
            builder.HasIndex(w => w.Code).IsUnique();
            builder.HasIndex(w => w.ConstituencyId);

            // Composite index for common lookups
            builder.HasIndex(w => new { w.ConstituencyId, w.Name });

            // Relationships
            builder.HasOne(w => w.Constituency)
                .WithMany(c => c.Wards)
                .HasForeignKey(w => w.ConstituencyId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent deletion of constituency with wards

            // Prevent deletion of ward with projects

            // Check constraints
            builder.ToTable(t => t.HasCheckConstraint("CK_Ward_Code_Format",
                "Code IS NULL OR Code LIKE '[A-Z0-9][A-Z0-9][A-Z0-9]'")); // Example: 3-character code

            // Query filter for soft delete (already in BaseEntityConfiguration, but can be explicit)
            builder.HasQueryFilter(w => !w.IsDeleted);
        }
    }
}
