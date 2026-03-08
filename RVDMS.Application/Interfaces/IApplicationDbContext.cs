using Microsoft.EntityFrameworkCore;
using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<RefreshToken> RefreshTokens { get; }
        DbSet<AuditLog> AuditLogs { get; }
        DbSet<Cluster> Clusters { get; }
        DbSet<Constituency> Constituencies { get; }
        DbSet<County> Counties { get; }
        DbSet<Department> Departments { get; }
        DbSet<Project> Projects { get; }
        DbSet<ProjectAssignment> ProjectAssignments { get; }
        DbSet<Ward> Wards { get; }
        DbSet<WeeklyReport> WeeklyReports { get; }



        // Save changes
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
