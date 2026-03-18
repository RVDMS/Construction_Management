using MediatR;
using RVDMS.Application.DTOs;
using RVDMS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Queries.Reports
{

    public class GetReportsByProjectQueryHandler : IRequestHandler<GetReportsByProjectQuery, List<WeeklyReportDto>>
    {
        private readonly IWeeklyReportRepository _repository;

        public GetReportsByProjectQueryHandler(IWeeklyReportRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<WeeklyReportDto>> Handle(GetReportsByProjectQuery request, CancellationToken cancellationToken)
        {
            var reports = await _repository.GetByProjectAsync(
            request.ProjectId,
            request.IncludeDeleted,
            cancellationToken);

            return reports.Select(report => new WeeklyReportDto
            {
                Id = report.Id,
                Title = report.Title,
                Description = report.Description,
                FilePath = report.FilePath,
                IsGeoValidated = report.IsGeoValidated,
                CreatedAt = report.CreatedAt,
                CreatedById = report.CreatedBy,
                ProjectId = report.ProjectId,
                Progress = report.Progress,
                CreatedByName = report.CreatedByUser != null
                    ? $"{report.CreatedByUser.FirstName} {report.CreatedByUser.LastName}"
                    : "Unknown",
                IsDeleted = report.IsDeleted
            }).ToList();
        }
    }
}
