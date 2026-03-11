using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RVDMS.Application.Common;
using RVDMS.Application.DTOs;
using RVDMS.Application.Queries.Users;

namespace RVDMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(PagedResponse<UserDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PagedResponse<UserDto>>> GetUsers([FromQuery] UserFilter filter, CancellationToken cancellationToken)
        {
            var query = new GetUsersQuery(filter);
            var result = await _mediator.Send(query, cancellationToken);
            return Ok(result);

        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UserDto>> GetUserById(
            string id,
            CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetUserByIdQuery(id), cancellationToken);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
