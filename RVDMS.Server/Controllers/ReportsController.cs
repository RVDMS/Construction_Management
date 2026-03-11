using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RVDMS.Application.Auth;
using RVDMS.Application.commands.WeeklyReportss;
using RVDMS.Application.Common;
using RVDMS.Application.DTOs;

namespace RVDMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class ReportsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReportsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Result<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Result<bool>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Result<bool>), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Result<bool>>> Delete(Guid id)
        {
            var command = new DeleteWeeklyReportCommand(id);
            var result = await _mediator.Send(command);

            if (!result.IsSuccess)
                return BadRequest(result);

            return Ok(result);
        }

        [Authorize(Policy = Permissions.SubmitReport)]
        [HttpPost]
        [ProducesResponseType(typeof(Result<WeeklyReportDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Result<WeeklyReportDto>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<Result<WeeklyReportDto>>> CreateReport(
    [FromForm] CreateWeeklyReportCommand command)
        {
            var result = await _mediator.Send(command);

            if (result.IsFailure)
                return BadRequest(result);

            return Ok(result);
        }

    }
}
