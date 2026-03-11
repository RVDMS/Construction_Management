using MediatR;
using RVDMS.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.WeeklyReportss
{
    public record DeleteWeeklyReportCommand(Guid ReportId) : IRequest<Result<bool>>;
    
    
}
