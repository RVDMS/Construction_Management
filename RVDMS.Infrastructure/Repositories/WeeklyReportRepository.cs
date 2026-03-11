using Microsoft.EntityFrameworkCore;
using RVDMS.Application.Interfaces;
using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<IEnumerable<WeeklyReport>> GetByProjectAsync(Guid projectId, CancellationToken cancellationToken)
        {
            return await _context.WeeklyReports
                .Where(r => r.ProjectId == projectId)
                .Include(r => r.CreatedByUser)
                .OrderByDescending(r => r.CreatedAt)
                .ToListAsync(cancellationToken);
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
