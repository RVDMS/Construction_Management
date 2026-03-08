using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Common
{
    public abstract class QueryFilter
    {
        private int _pageNumber = 1;
        private int _pageSize = 10;
        private const int MaxPageSize = 20;

        public int PageNumber
        {
            get => _pageNumber;
            set => _pageNumber = Math.Max(1, value);
        }

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = Math.Clamp(value, 1, MaxPageSize);
        }

        public string? SortBy { get; set; }
        public string? SearchTerm { get; set; }
    }
}
