using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Interfaces
{
    public interface ITokenHasher
    {
        string Hash(string token);
        bool verifyToken(string token, string hashedToken);
    }
}
