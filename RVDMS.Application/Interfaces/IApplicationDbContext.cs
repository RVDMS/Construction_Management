using Microsoft.EntityFrameworkCore;
using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<RefreshToken> RefreshTokens { get; }

        
        DbSet<ApplicationUser> Users { get; }

        // Save changes
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
