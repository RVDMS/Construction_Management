using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.DTOs
{
    public record AuthResponseDto(
        string UserId,
        UserDto User,
        string AccessToken,
        string RefreshToken);
   
}
