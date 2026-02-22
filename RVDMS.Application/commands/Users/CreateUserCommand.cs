using MediatR;
using RVDMS.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.Users
{
    public record CreateUserCommand : IRequest<UserDto>;
    
    
}
