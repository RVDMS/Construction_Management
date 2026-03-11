using MediatR;
using Microsoft.AspNetCore.Http;
using RVDMS.Application.Common;
using RVDMS.Application.DTOs;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.WeeklyReportss
{
    public record CreateWeeklyReportCommand(Guid ProjectId,
        string Title,
        string Description,
        IFormFile File,
        double SubmissionLatitude,
        double SubmissionLongitude) : IRequest<Result<WeeklyReportDto>>;
    
}
