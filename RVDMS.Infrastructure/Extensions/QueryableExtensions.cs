using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> ApplyPagination<T>(
            this IQueryable<T> query,
            int pageNumber,
            int pageSize)
        {
            return query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);
        }

        public static IQueryable<T> ApplySorting<T>(
            this IQueryable<T> query,
            string? sortBy,
            string defaultSort = "Id") where T : class
        {
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = defaultSort;

            var allowedProperties = typeof(T)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Select(p => p.Name)
                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            var sortExpressions = new List<string>();

            foreach (var part in sortBy.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
            {
                var tokens = part.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 0 || !allowedProperties.Contains(tokens[0]))
                    continue;

                var direction = tokens.Length > 1 &&
                    (tokens[1].Equals("desc", StringComparison.OrdinalIgnoreCase) ||
                     tokens[1].Equals("descending", StringComparison.OrdinalIgnoreCase))
                    ? "descending"
                    : "ascending";

                sortExpressions.Add($"{tokens[0]} {direction}");
            }

            return sortExpressions.Count > 0
                ? query.OrderBy(string.Join(", ", sortExpressions))
                : query.OrderBy(defaultSort);
        }
    }
}
