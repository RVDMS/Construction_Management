using Microsoft.EntityFrameworkCore;
using RVDMS.Application.Interfaces;
using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace RVDMS.Infrastructure.Repositories
{
    public class WeeklyReportRepository : IWeeklyReportRepository
    {
        private readonly IApplicationDbContext _context;

        public WeeklyReportRepository(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(WeeklyReport report, CancellationToken cancellationToken)
        {
            await _context.WeeklyReports.AddAsync(report, cancellationToken);
        }

        public async Task DeleteAsync(WeeklyReport report, CancellationToken cancellationToken = default)
        {
            report.IsDeleted = true;
            
            _context.WeeklyReports.Update(report);

            

            await Task.CompletedTask;
        }

        public async Task<WeeklyReport?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _context.WeeklyReports
                .Include(r => r.Project)
                .Include(r => r.CreatedByUser)
                .FirstOrDefaultAsync(r => r.Id == id, cancellationToken);
        }

        public async Task<IEnumerable<WeeklyReport>> GetByProjectAsync(Guid projectId, bool includeDeleted, CancellationToken cancellationToken)
        {
            var query = _context.WeeklyReports
        .Where(r => r.ProjectId == projectId);

            // 👇 Apply soft delete filter here
            if (!includeDeleted)
            {
                query = query.Where(r => !r.IsDeleted);
            }
            return await query
                .AsNoTracking()
                .Include(r => r.CreatedByUser)
                .OrderByDescending(r => r.CreatedAt)
                .ToListAsync(cancellationToken);
        }

       

        public async Task SaveChangesAsync(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<int> SoftDeleteOldReportsAsync(DateTime cutoff, CancellationToken ct)
        {
            return await _context.WeeklyReports
        .Where(r => !r.IsDeleted && r.CreatedAt <= cutoff)
        .ExecuteUpdateAsync(setters => setters
            .SetProperty(r => r.IsDeleted, true)
            .SetProperty(r => r.UpdatedAt, DateTime.UtcNow)
            .SetProperty(r => r.UpdatedBy, "System"),
            ct);
        }
    }
}
