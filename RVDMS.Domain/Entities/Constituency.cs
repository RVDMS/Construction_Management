using RVDMS.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Entities
{
    public class Constituency : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Code { get; set; }

        // Foreign keys
        public Guid CountyId { get; set; }

        // Navigation properties
        public virtual County County { get; set; } = null!;
        public virtual ICollection<Ward> Wards { get; set; } = new List<Ward>();
    }
}
