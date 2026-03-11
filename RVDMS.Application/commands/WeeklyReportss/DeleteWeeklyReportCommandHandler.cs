using MediatR;
using RVDMS.Application.Common;
using RVDMS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.WeeklyReportss
{
    public class DeleteWeeklyReportHandler : IRequestHandler<DeleteWeeklyReportCommand, Result<bool>>
    {
        private readonly IWeeklyReportRepository _repository;
        private readonly ICurrentUserService _currentUser;
        private readonly IFileService _fileService;

        public DeleteWeeklyReportHandler(
            IWeeklyReportRepository repository,
            ICurrentUserService currentUser,
            IFileService fileService)
        {
            _repository = repository;
            _currentUser = currentUser;
            _fileService = fileService;
        }

        public async Task<Result<bool>> Handle(DeleteWeeklyReportCommand request, CancellationToken cancellationToken)
        {
            try
            {
                // Get the report
                var report = await _repository.GetByIdAsync(request.ReportId, cancellationToken);
                if (report == null)
                {
                    return Result<bool>.Failure("Weekly report not found.");
                }

                // Check if the current user is the creator (COW who created it)
                if (report.CreatedBy != _currentUser.UserId)
                {
                    return Result<bool>.Failure("You can only delete reports that you created.");
                }

                // Delete file from Cloudinary first
                if (!string.IsNullOrEmpty(report.FilePath))
                {
                    try
                    {
                        await _fileService.DeleteFileAsync(report.FilePath);
                    }
                    catch (Exception ex)
                    {
                        // Log but don't fail - you might want to add ILogger here
                        Console.WriteLine($"Failed to delete file from Cloudinary: {ex.Message}");
                    }
                }

                // Soft delete the report
                await _repository.DeleteAsync(report, cancellationToken);
                await _repository.SaveChangesAsync(cancellationToken);

                return Result<bool>.Success(true);
            }
            catch (Exception ex)
            {
                return Result<bool>.Failure($"An error occurred while deleting the report: {ex.Message}");
            }
        }
    }
    }

