using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.WeeklyReportss
{
    public class CreateWeeklyReportCommandValidator : AbstractValidator<CreateWeeklyReportCommand>
    {
        private readonly string[] _allowedFileExtensions = { ".pdf", ".xls", ".xlsx", ".xlsm" };
        private readonly long _maxFileSize = 10 * 1024 * 1024; // 10MB
        public CreateWeeklyReportCommandValidator()
        {
            RuleFor(x => x.ProjectId)
                .NotEmpty().WithMessage("Project ID is required.")
                .NotEqual(Guid.Empty).WithMessage("Invalid Project ID.");

            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required.")
                .MinimumLength(3).WithMessage("Title must be at least 3 characters long.")
                .MaximumLength(300).WithMessage("Title cannot exceed 300 characters.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Description is required.")
                .MaximumLength(2000).WithMessage("Description cannot exceed 2000 characters.");

            RuleFor(x => x.File)
                .NotNull().WithMessage("File is required.")
                .Must(BeAValidFile).WithMessage($"Only PDF and Excel files (.pdf, .xls, .xlsx, .xlsm) are allowed.")
                .Must(BeWithinFileSize).WithMessage($"File size cannot exceed {_maxFileSize / 1024 / 1024}MB.");

            RuleFor(x => x.SubmissionLatitude)
                .InclusiveBetween(-90, 90)
                .WithMessage("Latitude must be between -90 and 90 degrees.");

            RuleFor(x => x.SubmissionLongitude)
                .InclusiveBetween(-180, 180)
                .WithMessage("Longitude must be between -180 and 180 degrees.");

        }
        private bool BeAValidFile(IFormFile? file)
        {
            if (file == null) return false;

            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
            return _allowedFileExtensions.Contains(extension);
        }

        private bool BeWithinFileSize(IFormFile? file)
        {
            if (file == null) return false;
            return file.Length <= _maxFileSize;
        }
    }
}
