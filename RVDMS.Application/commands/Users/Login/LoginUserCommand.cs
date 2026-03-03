using MediatR;
using RVDMS.Application.Common;
using RVDMS.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.Users.Login
{
    public class LoginUserCommand : IRequest<Result<AuthResponseDto>>
    {
       
            // User credentials
            public string Email { get; init; } = string.Empty;
            public string Password { get; init; } = string.Empty;

            // Current location sent by client
            public double CurrentLatitude { get; init; }
            public double CurrentLongitude { get; init; }
       
    }
}
