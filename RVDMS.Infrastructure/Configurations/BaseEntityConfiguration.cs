using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RVDMS.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Configurations
{
    public static class BaseEntityConfiguration 
    {
        public static void ConfigureBaseEntity<T>(EntityTypeBuilder<T> builder) where T : BaseEntity
        {
            

            builder.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()");

            builder.Property(e => e.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("NOW()");

            builder.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("NOW()");

            builder.Property(e => e.CreatedBy)
                .HasMaxLength(450);

            builder.Property(e => e.UpdatedBy)
                .HasMaxLength(450);

            builder.HasQueryFilter(e => !e.IsDeleted);

            // Indexes for common queries
            builder.HasIndex(e => e.CreatedAt);
            builder.HasIndex(e => e.CreatedBy);
            builder.HasIndex(e => e.IsDeleted);
        }
    }
}
