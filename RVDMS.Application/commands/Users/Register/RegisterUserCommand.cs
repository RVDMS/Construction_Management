using MediatR;
using RVDMS.Application.Common;
using RVDMS.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.Users.Register
{
    public record RegisterUserCommand : IRequest<Result<AuthResponseDto>>
    {
        
        public string UserName { get; init; } = string.Empty;
        public string Email { get; init; } = string.Empty;
        public string FirstName { get; init; } = string.Empty;
        public string LastName { get; init; } = string.Empty;
        public string? PhoneNumber { get; init; }
        public string Password { get; init; } = string.Empty;

        // User's base location (where they'll work from)
        public double BaseLatitude { get; init; }
        public double BaseLongitude { get; init; }
        public int BaseRadiusInMeters { get; init; } = 500; // Default 100m radius

        
    };
    
    
}
