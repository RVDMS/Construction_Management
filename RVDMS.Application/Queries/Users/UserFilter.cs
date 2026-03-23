using RVDMS.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Queries.Users
{
    public class UserFilter : QueryFilter
    {
        public List<string> Role { get; set; } = new();

        public Guid? CountyId { get; set; }

        public Guid? ConstituencyId { get; set; }

        public Guid? WardId { get; set; }

        public bool? IsActive { get; set; }

      
    }
}
