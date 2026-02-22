using RVDMS.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Entities
{
    public class County : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Code { get; set; }

        public virtual ICollection<Constituency> Constituencies { get; set; } = new List<Constituency>();
    }
}
