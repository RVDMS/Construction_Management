using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.DTOs
{
    public record AuthResponseDto(
        UserDto User,
        string AccessToken,
        string RefreshToken);
   
}
