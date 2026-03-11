using MediatR;
using RVDMS.Application.Common;
using RVDMS.Application.DTOs;
using RVDMS.Application.Interfaces;
using RVDMS.Domain.Entities;
using RVDMS.Domain.Interfaces;
using RVDMS.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.WeeklyReportss
{
    public class CreateWeeklyReportCommandHandler : IRequestHandler<CreateWeeklyReportCommand, Result<WeeklyReportDto>>
    {
        private readonly IWeeklyReportRepository _repository;
        private readonly IProjectRepository _projectRepository;
        private readonly ICurrentUserService _currentUser;
        private readonly IFileService _fileService;
        private readonly IGeoValidationService _geoValidation;

        public CreateWeeklyReportCommandHandler(IWeeklyReportRepository repository,
            IProjectRepository projectRepository,
            ICurrentUserService currentUser,
            IFileService fileService,
            IGeoValidationService geoValidation)
        {
            _repository = repository;
            _projectRepository = projectRepository;
            _currentUser = currentUser;
            _fileService = fileService;
            _geoValidation = geoValidation;
        }
        public async Task<Result<WeeklyReportDto>> Handle(CreateWeeklyReportCommand request, CancellationToken cancellationToken)
        {
            try
            {

                // 1. Validate file type
                if (!_fileService.IsValidFileType(request.File.FileName))
                {
                    return Result<WeeklyReportDto>.Failure(
                        "Only PDF and Excel files (.pdf, .xls, .xlsx, .xlsm) are allowed."
                    );
                }

                // 2. Validate file size
                if (request.File.Length > _fileService.GetMaxFileSize())
                {
                    return Result<WeeklyReportDto>.Failure(
                        $"File size exceeds maximum allowed size of {_fileService.GetMaxFileSize() / 1024 / 1024}MB."
                    );
                }

                // 3. Get project with location
                var project = await _projectRepository.GetByIdAsync(request.ProjectId, cancellationToken);
                if (project == null)
                    return Result<WeeklyReportDto>.Failure("Project not found.");

                // 4. Create project location object
                var projectLocation = new Location(
                    project.Latitude,
                    project.Longitude,
                    project.RadiusInMeters
                );

                // 5. Create submission location (owned type)
                var submissionLocation = new Location(
                    request.SubmissionLatitude,
                    request.SubmissionLongitude,
                    0 // Radius doesn't matter for submission
                );

                // 6. Validate geo-location
                var isWithinProjectSite = _geoValidation.IsWithinProjectSite(
                    projectLocation,
                    submissionLocation
                );

                if (!isWithinProjectSite)
                {
                    var distance = _geoValidation.CalculateDistance(projectLocation, submissionLocation);
                    return Result<WeeklyReportDto>.Failure(
                        $"You must be within {project.RadiusInMeters:N0} meters of the project site to submit a report. " +
                        $"You are currently {distance:N0} meters away."
                    );
                }

                // 7. Upload file to Cloudinary
                string filePath;
                try
                {
                    byte[] fileData;
                    using (var ms = new MemoryStream())
                    {
                        await request.File.CopyToAsync(ms, cancellationToken);
                        fileData = ms.ToArray();
                    }

                    filePath = await _fileService.UploadFileAsync(
                        fileData,
                        request.File.FileName,
                        $"projects/{request.ProjectId}/weekly-reports"
                    );
                }
                catch (InvalidOperationException ex) // Catch file validation errors
                {
                    return Result<WeeklyReportDto>.Failure(ex.Message);
                }
                catch (Exception ex)
                {
                    return Result<WeeklyReportDto>.Failure($"File upload failed: {ex.Message}");
                }
                // 8. Create report entity with Location owned type
                var report = new WeeklyReport
                {
                    Id = Guid.NewGuid(),
                    Title = request.Title,
                    Description = request.Description,
                    FilePath = filePath,
                    ProjectId = project.Id,
                    SubmissionLocation = submissionLocation, // This will be stored as owned properties
                    CreatedBy = _currentUser.UserId,
                    CreatedAt = DateTime.UtcNow
                };

                // 9. Validate location (sets IsGeoValidated)
                report.ValidateLocation(projectLocation);

                // 10. Save to database
                await _repository.AddAsync(report, cancellationToken);
                await _repository.SaveChangesAsync(cancellationToken);

                // 11. Return DTO
                return Result<WeeklyReportDto>.Success(new WeeklyReportDto
                {
                    Id = report.Id,
                    Title = report.Title,
                    Description = report.Description,
                    FilePath = report.FilePath,
                    IsGeoValidated = report.IsGeoValidated,
                    CreatedAt = report.CreatedAt,
                    CreatedById = report.CreatedBy,
                    ProjectId = report.ProjectId
                });
            }
            catch (Exception ex)
            {

                return Result<WeeklyReportDto>.Failure($"An error occurred: {ex.Message}");
            }
        }
    }
}
