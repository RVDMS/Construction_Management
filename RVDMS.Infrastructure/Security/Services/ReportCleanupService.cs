using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RVDMS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Security.Services
{
    public class ReportCleanupService : BackgroundService
    {
        private readonly IServiceProvider _services;
        private readonly ILogger<ReportCleanupService> _logger;
        private readonly TimeSpan _interval = TimeSpan.FromHours(24);

        public ReportCleanupService(
            IServiceProvider services,
            ILogger<ReportCleanupService> logger)
        {
            _services = services;
            _logger = logger;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Report Cleanup Service started.");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    await CleanupOldReports(stoppingToken);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error occurred while cleaning up old reports.");
                }

                await Task.Delay(_interval, stoppingToken);
            }
        }

        private async Task CleanupOldReports(CancellationToken stoppingToken)
        {
            using var scope = _services.CreateScope();
            var reportRepository = scope.ServiceProvider.GetRequiredService<IWeeklyReportRepository>();

            var cutoff = DateTime.UtcNow.AddDays(-21);

            var affectedRows = await reportRepository
                .SoftDeleteOldReportsAsync(cutoff, stoppingToken);

            if (affectedRows > 0)
            {
                _logger.LogInformation($"Soft-deleted {affectedRows} reports older than 3 weeks.");
            }
            else
            {
                _logger.LogInformation("No old reports found to delete.");
            }
        }
    }
}
