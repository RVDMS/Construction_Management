using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RVDMS.Application.Interfaces;
using RVDMS.Application.Queries.Users;
using RVDMS.Domain.Entities;
using RVDMS.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
       

        public UserRepository(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
           
        }
        public async Task<int> CountAsync(UserFilter filter, CancellationToken cancellationToken = default)
        {
            var query = _userManager.Users.AsQueryable();

            // ✅ ROLE FILTER (same logic)
            if (filter.Role != null && filter.Role.Any())
            {
                var userIdsInRoles = new List<string>();

                foreach (var role in filter.Role)
                {
                    var usersInRole = await _userManager.GetUsersInRoleAsync(role);
                    userIdsInRoles.AddRange(usersInRole.Select(u => u.Id));
                }

                query = query.Where(u => userIdsInRoles.Contains(u.Id));
            }

            if (filter.IsActive.HasValue)
                query = query.Where(u => u.IsActive == filter.IsActive.Value);

            if (!string.IsNullOrWhiteSpace(filter.SearchTerm))
            {
                var search = $"%{filter.SearchTerm}%";
                query = query.Where(u =>
                    EF.Functions.ILike(u.FirstName, search) ||
                    EF.Functions.ILike(u.LastName, search) ||
                    EF.Functions.ILike(u.Email, search) ||
                    EF.Functions.ILike(u.UserName, search));
            }

            return await query.CountAsync(cancellationToken);
        }

        public async Task<IReadOnlyList<ApplicationUser>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _userManager.Users
                 .Include(u => u.ProjectAssignments)
                     .ThenInclude(pa => pa.Project)
                         .ThenInclude(p => p.Ward)
                             .ThenInclude(w => w.Constituency)
                                 .ThenInclude(c => c.County)
                 .AsNoTracking()
                 .ToListAsync(cancellationToken);
        }

        public async Task<ApplicationUser?> GetByIdAsync(string id, CancellationToken cancellationToken = default)
        {
            return await _userManager.Users
                 .Include(u => u.ProjectAssignments)
                     .ThenInclude(pa => pa.Project)
                         .ThenInclude(p => p.Ward)
                             .ThenInclude(w => w.Constituency)
                                 .ThenInclude(c => c.County)
                 .AsNoTracking()
                 .FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
        }

        public async Task<IReadOnlyList<ApplicationUser>> GetFilteredAsync(
    UserFilter filter,
    CancellationToken cancellationToken = default)
        {
            var query = _userManager.Users
                .Include(u => u.ProjectAssignments)
                    .ThenInclude(pa => pa.Project)
                        .ThenInclude(p => p.Ward)
                            .ThenInclude(w => w.Constituency)
                                .ThenInclude(c => c.County)
                .AsNoTracking()
                .AsQueryable();

            // ✅ ROLE FILTER (FIRST - IMPORTANT)
            if (filter.Role != null && filter.Role.Any())
            {
                var userIdsInRoles = new List<string>();

                foreach (var role in filter.Role)
                {
                    var usersInRole = await _userManager.GetUsersInRoleAsync(role);
                    userIdsInRoles.AddRange(usersInRole.Select(u => u.Id));
                }

                query = query.Where(u => userIdsInRoles.Contains(u.Id));
            }

            // ✅ Filter by active
            if (filter.IsActive.HasValue)
                query = query.Where(u => u.IsActive == filter.IsActive.Value);

            // ✅ Search term
            if (!string.IsNullOrWhiteSpace(filter.SearchTerm))
            {
                var search = $"%{filter.SearchTerm}%";
                query = query.Where(u =>
                    EF.Functions.ILike(u.FirstName, search) ||
                    EF.Functions.ILike(u.LastName, search) ||
                    EF.Functions.ILike(u.Email, search) ||
                    EF.Functions.ILike(u.UserName, search));
            }

            // ✅ Location filters
            if (filter.WardId.HasValue)
                query = query.Where(u =>
                    u.ProjectAssignments.Any(pa => pa.Project.WardId == filter.WardId.Value));

            if (filter.ConstituencyId.HasValue)
                query = query.Where(u =>
                    u.ProjectAssignments.Any(pa =>
                        pa.Project.Ward.Constituency.Id == filter.ConstituencyId.Value));

            if (filter.CountyId.HasValue)
                query = query.Where(u =>
                    u.ProjectAssignments.Any(pa =>
                        pa.Project.Ward.Constituency.County.Id == filter.CountyId.Value));

            // ✅ Sorting
            query = query.ApplySorting(filter.SortBy, "FirstName");

            // ✅ Pagination (LAST ALWAYS)
            query = query.ApplyPagination(filter.PageNumber, filter.PageSize);

            return await query.ToListAsync(cancellationToken);
        }
    }
}
