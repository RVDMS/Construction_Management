using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RVDMS.Domain.Common;
using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Configurations
{
    public class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
    {
        
        public void Configure(EntityTypeBuilder<AuditLog> builder)
        {
            BaseEntityConfiguration.ConfigureBaseEntity(builder);

            builder.ToTable("AuditLogs");
            

            

            builder.Property(al => al.UserId)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(al => al.EntityType)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(al => al.EntityId)
                .HasMaxLength(100);

            builder.Property(al => al.IpAddress)
                .HasMaxLength(50);

            builder.Property(al => al.UserAgent)
                .HasMaxLength(500);

            builder.Property(al => al.OldValues)
                .HasColumnType("nvarchar(max)");

            builder.Property(al => al.NewValues)
                .HasColumnType("nvarchar(max)");

            builder.Property(al => al.Timestamp)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            // Indexes
            builder.HasIndex(al => al.UserId);
            builder.HasIndex(al => al.EntityType);
            builder.HasIndex(al => al.EntityId);
            builder.HasIndex(al => al.Timestamp);
            builder.HasIndex(al => al.Action);

            // Convert enum to string
            builder.Property(al => al.Action)
                .HasConversion<string>()
                .HasMaxLength(50)
                .IsRequired();

            // Relationships
            builder.HasOne(al => al.User)  // navigation property in AuditLog
                 .WithMany(u => u.AuditLogs)
                 .HasForeignKey(al => al.UserId)
                 .OnDelete(DeleteBehavior.Restrict);

            
        }
    }
}
