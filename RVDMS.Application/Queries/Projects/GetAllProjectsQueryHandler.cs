using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using RVDMS.Application.Common;
using RVDMS.Application.Interfaces;
using RVDMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Queries.Projects
{
    public class GetAllProjectsQueryHandler : IRequestHandler<GetAllProjectsQuery, PagedResponse<ProjectDto>>
    {
        private readonly IProjectRepository _repository;

        public GetAllProjectsQueryHandler(IProjectRepository repository)
        {
            _repository = repository;
        }
        public async Task<PagedResponse<ProjectDto>> Handle(GetAllProjectsQuery request, CancellationToken cancellationToken)
        {
            var filter = request.Filter;
            var projects = await _repository.GetFilteredAsync(filter, cancellationToken);
            var totalRecords = await _repository.CountAsync(filter, cancellationToken);

            var projectDtos = projects.Select(p =>
            {
                var progress = p.Progress;

                var assignments = p.ProjectAssignments.Where(a => a.RevokedAt == null).ToList();
                var cow = assignments.FirstOrDefault(a => a.Role == "COW");
                var tl = assignments.FirstOrDefault(a => a.Role == "TL");
                var css = assignments.Where(a => a.Role == "CS").Select(a => $"{a.User?.FirstName} {a.User?.LastName}").ToList();
                var latestReport = p.WeeklyReports.OrderByDescending(r => r.CreatedAt).FirstOrDefault();

                return new ProjectDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    TenderNumber = p.TenderNumber,
                    ProjectLeadName = p.ProjectLead != null ? $"{p.ProjectLead.FirstName} {p.ProjectLead.LastName}" : null,
                    ProjectLeadId = p.ProjectLeadId,
                    ContractorName = p.ContractorName,
                    ConsultantName = p.ConsultantName,
                    Description = p.Description,
                    ContractSum = p.ContractSum,
                    StartDate = p.StartDate,
                    EndDate = p.EndDate,
                    Status = p.Status.ToString(),

                    Latitude = p.Latitude,
                    Longitude = p.Longitude,
                    RadiusInMeters = p.RadiusInMeters,
                    County = p.Ward?.Constituency?.County?.Name ?? string.Empty,
                    Constituency = p.Ward?.Constituency?.Name ?? string.Empty,
                    Ward = p.Ward?.Name ?? string.Empty,
                    Cluster = p.Cluster?.Name,
                    ClusterId = p.ClusterId,

                    CurrentPhysicalProgress = p.CurrentPhysicalProgress,
                    TimeElapsedPercentage = progress.TimeElapsedPercentage,
                    Variance = progress.Variance,
                    ProgressStatus = progress.Status.ToString(),
                    ProgressStatusColor = progress.GetStatusColor(),
                    LastProgressUpdate = p.LastProgressUpdate,
                    LastUpdatedById = p.LastUpdatedById,
                    LastUpdatedBy = p.LastUpdatedById,
                    IsAtRisk = progress.Status == ProgressStatus.Delayed || progress.Status == ProgressStatus.Slow,
                    DaysRemaining = (int)Math.Max(0, (p.EndDate - System.DateTime.UtcNow).TotalDays),
                    RemainingBudget = p.ContractSum * (1 - p.CurrentPhysicalProgress / 100),
                    EstimatedCompletionCost = p.ContractSum * ((100 - p.CurrentPhysicalProgress) / 100),

                    TotalAssignments = assignments.Count,
                    ClerkOfWorks = cow != null ? $"{cow.User?.FirstName} {cow.User?.LastName}" : null,
                    TechnicalLead = tl != null ? $"{tl.User?.FirstName} {tl.User?.LastName}" : null,
                    ClusterSupervisors = css,

                    TotalWeeklyReports = p.WeeklyReports.Count,
                    LastReportDate = latestReport?.CreatedAt,
                    HasOverdueReports = latestReport != null && latestReport.CreatedAt < System.DateTime.UtcNow.AddDays(-7)
                };
            }).ToList();

            return new PagedResponse<ProjectDto>
            {
                Data = projectDtos,
                PageNumber = filter.PageNumber,
                PageSize = filter.PageSize,
                TotalRecords = totalRecords,
                TotalPages = (int)Math.Ceiling(totalRecords / (double)filter.PageSize)
            };
        }
    }
}
