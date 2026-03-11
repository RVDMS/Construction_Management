using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RVDMS.Application.Common;
using RVDMS.Application.Queries.Projects;

namespace RVDMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProjectsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjectsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get a paged list of projects based on filters.
        /// </summary>
        
        [HttpGet]
        [ProducesResponseType(typeof(PagedResponse<ProjectDto>), 200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetProjects([FromQuery] ProjectFilter filter, CancellationToken cancellationToken)
        {
            var query = new GetAllProjectsQuery(filter);
            var result = await _mediator.Send(query, cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Get a single project by its Id.
        /// </summary>
        
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProjectDto), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetProjectById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var query = new GetProjectByIdQuery(id);
            var project = await _mediator.Send(query, cancellationToken);

            if (project == null)
                return NotFound($"Project with Id {id} was not found.");

            return Ok(project);
        }
    }
}
