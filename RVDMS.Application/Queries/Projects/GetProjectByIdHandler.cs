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
    public class GetProjectByIdHandler : IRequestHandler<GetProjectByIdQuery, ProjectDto>
    {
        private readonly IProjectRepository _repository;
        private readonly ICurrentUserService _currentUserService;

        public GetProjectByIdHandler(IProjectRepository repository, ICurrentUserService currentUserService)
        {
            _repository = repository;
            _currentUserService = currentUserService;
        }
        public async Task<ProjectDto> Handle(GetProjectByIdQuery request, CancellationToken cancellationToken)
        {
            var project = await _repository.GetByIdAsync(request.Id, cancellationToken);
            if (project == null) return null;

            var progress = project.Progress;
            var activeAssignments = project.ProjectAssignments.Where(pa => pa.RevokedAt == null).ToList();

            // Role-based access
            var roles = _currentUserService.Roles.ToList();
            var userId = _currentUserService.UserId;

            // COW can only access their assigned project
            if (roles.Contains("COW") && !activeAssignments.Any(a => a.UserId == userId && a.Role == "COW"))
            {
                return null; // Not authorized to see this project
            }

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
                ClusterSupervisor = css.FirstOrDefault() != null
                            ? $"{css.First().User?.FirstName} {css.First().User?.LastName}"
                            : null,
                ClusterSupervisors = css.Select(cs => $"{cs.User?.FirstName} {cs.User?.LastName}").ToList(),

                TotalWeeklyReports = project.WeeklyReports.Count,
                LastReportDate = latestReport?.CreatedAt,
                HasOverdueReports = latestReport != null && latestReport.CreatedAt < DateTime.UtcNow.AddDays(-7)
            };
        }
        }
}
