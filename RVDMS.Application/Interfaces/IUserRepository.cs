using RVDMS.Application.Queries.Users;
using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<ApplicationUser?> GetByIdAsync(string id, CancellationToken cancellationToken = default);

        Task<IReadOnlyList<ApplicationUser>> GetFilteredAsync(UserFilter filter, CancellationToken cancellationToken = default);

        Task<int> CountAsync(UserFilter filter, CancellationToken cancellationToken = default);

        Task<IReadOnlyList<ApplicationUser>> GetAllAsync(CancellationToken cancellationToken = default);
    }
}
