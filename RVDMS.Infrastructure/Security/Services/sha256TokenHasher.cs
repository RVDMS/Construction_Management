using RVDMS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Security.Services
{
    public class sha256TokenHasher : ITokenHasher
    {
        public string Hash(string token)
        {
             using var sha = SHA256.Create();
             var bytes = Encoding.UTF8.GetBytes(token);
             var hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);

        }

        public bool verifyToken(string token, string hashedToken)
        {
            var hashedInput = Hash(token);
            return hashedInput == hashedToken;
        }
    }
}
