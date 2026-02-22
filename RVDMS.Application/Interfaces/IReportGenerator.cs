using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Interfaces
{
    public interface IReportGenerator
    {
        Task<byte[]> GenerateProjectProgressReport(Guid projectId);
        Task<byte[]> GenerateRegionalReport(Guid countyId, DateTime fromDate, DateTime toDate);
        Task<byte[]> GenerateDashboardSummary(Guid? countyId = null);
    }
}
