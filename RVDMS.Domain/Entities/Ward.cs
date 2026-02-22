using RVDMS.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Entities
{
    public class Ward : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Code { get; set; }

        // Foreign keys
        public Guid ConstituencyId { get; set; }

        // Navigation properties
        public virtual Constituency Constituency { get; set; } = null!;
        public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}
