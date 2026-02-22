using RVDMS.Domain.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Code { get; set; }
        public string? Description { get; set; }

        // Navigation properties
        public virtual ICollection<Cluster> Clusters { get; set; } = new List<Cluster>();
    }
}
