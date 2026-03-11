using MediatR;
using RVDMS.Application.Common;
using RVDMS.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.Users.AuthToken
{
    public record RefreshTokenCommand(string RefreshToken)
    : IRequest<Result<AuthResponseDto>>;
}
