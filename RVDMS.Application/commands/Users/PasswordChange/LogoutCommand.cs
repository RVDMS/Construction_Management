using MediatR;
using RVDMS.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.commands.Users.PasswordChange
{
    public class LogoutCommand : IRequest<Result<string>>
    {
    }
}
