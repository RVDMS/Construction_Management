using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Interfaces
{
    public interface IWeeklyReportRepository
    {
        Task AddAsync(WeeklyReport report, CancellationToken cancellationToken);
        Task<WeeklyReport?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<WeeklyReport>> GetByProjectAsync(Guid projectId, CancellationToken cancellationToken);
        Task DeleteAsync(WeeklyReport report, CancellationToken cancellationToken = default);
        Task SaveChangesAsync(CancellationToken cancellationToken);
    }
}
