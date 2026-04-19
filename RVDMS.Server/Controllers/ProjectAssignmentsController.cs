using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RVDMS.Application.commands.ProjectAssignments;
using RVDMS.Application.DTOs;
using RVDMS.Application.Queries.ProjectAssignments;
using RVDMS.Domain.Constants;

namespace RVDMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = $"{UserRoles.RegionalLead},{UserRoles.SuperAdmin}, {UserRoles.CountyDirector},{UserRoles.ClusterSupervisor}, {UserRoles.TechnicalLead}")]
    public class ProjectAssignmentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjectAssignmentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("assignable-users")]
        public async Task<ActionResult<List<AssignableUserDto>>> GetAssignableUsers(
            [FromQuery] string? role,
            CancellationToken cancellationToken)
        {
            var query = new GetAssignableUsersQuery { Role = role };
            var result = await _mediator.Send(query, cancellationToken);
            return Ok(result);
        }

        [HttpGet("project/{projectId}")]
        public async Task<ActionResult<List<ProjectAssignmentDto>>> GetProjectAssignments(
            Guid projectId,
            CancellationToken cancellationToken)
        {
            var query = new GetProjectAssignmentsQuery { ProjectId = projectId };
            var result = await _mediator.Send(query, cancellationToken);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ProjectAssignmentDto>> AssignProject(
            [FromBody] AssignProjectCommand command,
            CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(command, cancellationToken);
            if (!result.IsSuccess)
                return BadRequest(result.Error);
            return Ok(result.Value);
        }

        [HttpDelete("{assignmentId}")]
        public async Task<ActionResult> RevokeAssignment(
            Guid assignmentId,
            CancellationToken cancellationToken)
        {
            var command = new RevokeProjectAssignmentCommand { AssignmentId = assignmentId };
            var result = await _mediator.Send(command, cancellationToken);
            if (!result.IsSuccess)
                return BadRequest(result.Error);
            return Ok(new { message = "Assignment revoked successfully" });
        }
    }
}
