using MediatR;
using RVDMS.Application.Interfaces;
using RVDMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Queries.Projects
{
    public class GetMyProjectQueryHandler : IRequestHandler<GetMyProjectQuery, ProjectDto>
    {
        private readonly IProjectRepository _repository;
        private readonly ICurrentUserService _currentUserService;

        public GetMyProjectQueryHandler(
            IProjectRepository repository,
            ICurrentUserService currentUserService)
        {
            _repository = repository;
            _currentUserService = currentUserService;
        }
        public async Task<ProjectDto> Handle(GetMyProjectQuery request, CancellationToken cancellationToken)
        {
            var userId = _currentUserService.UserId;
            var roles = _currentUserService.Roles.ToList();

            // Only COWs should access this
            if (!roles.Contains("COW"))
            {
                throw new UnauthorizedAccessException("Only COW can access this");
            }

            var project = await _repository.GetProjectByUserIdAsync(userId, cancellationToken);

            if (project == null)
                return null;

            var progress = project.Progress;
            var activeAssignments = project.ProjectAssignments.Where(pa => pa.RevokedAt == null).ToList();

            var cow = activeAssignments.FirstOrDefault(a => a.Role == "COW");
            var tl = activeAssignments.FirstOrDefault(a => a.Role == "TL");
            var css = activeAssignments.Where(a => a.Role == "CS").ToList();
            var latestReport = project.WeeklyReports.OrderByDescending(wr => wr.CreatedAt).FirstOrDefault();

            return new ProjectDto
            {
                Id = project.Id,
                Name = project.Name,
                TenderNumber = project.TenderNumber,
                ProjectLeadName = project.ProjectLead != null ? $"{project.ProjectLead.FirstName} {project.ProjectLead.LastName}" : null,
                ProjectLeadId = project.ProjectLeadId,
                ContractorName = project.ContractorName,
                ConsultantName = project.ConsultantName,
                Description = project.Description,
                ContractSum = project.ContractSum,
                StartDate = project.StartDate,
                EndDate = project.EndDate,
                Status = project.Status.ToString(),

                Latitude = project.Latitude,
                Longitude = project.Longitude,
                RadiusInMeters = project.RadiusInMeters,
                County = project.Ward?.Constituency?.County?.Name ?? string.Empty,
                Constituency = project.Ward?.Constituency?.Name ?? string.Empty,
                Ward = project.Ward?.Name ?? string.Empty,
                Cluster = project.Cluster?.Name,
                ClusterId = project.ClusterId,

                CurrentPhysicalProgress = project.CurrentPhysicalProgress,
                LastProgressUpdate = project.LastProgressUpdate,
                LastUpdatedById = project.LastUpdatedById,

                TimeElapsedPercentage = Math.Round(progress.TimeElapsedPercentage, 2),
                Variance = Math.Round(progress.Variance, 2),
                ProgressStatus = progress.Status.ToString(),
                ProgressStatusColor = progress.GetStatusColor(),
                IsAtRisk = progress.Status == ProgressStatus.Delayed || progress.Status == ProgressStatus.Slow,

                DaysRemaining = Math.Max(0, (project.EndDate - DateTime.UtcNow).Days),
                RemainingBudget = Math.Round(project.ContractSum * (1 - (project.CurrentPhysicalProgress / 100)), 2),
                EstimatedCompletionCost = Math.Round(project.ContractSum * ((100 - project.CurrentPhysicalProgress) / 100), 2),

                TotalAssignments = activeAssignments.Count,
                ClerkOfWorks = cow != null ? $"{cow.User?.FirstName} {cow.User?.LastName}" : null,
                TechnicalLead = tl != null ? $"{tl.User?.FirstName} {tl.User?.LastName}" : null,
                ClusterSupervisors = css.Select(cs => $"{cs.User?.FirstName} {cs.User?.LastName}").ToList(),

                TotalWeeklyReports = project.WeeklyReports.Count,
                LastReportDate = latestReport?.CreatedAt,
                HasOverdueReports = latestReport != null && latestReport.CreatedAt < DateTime.UtcNow.AddDays(-7)
            };
            }
    }
}
