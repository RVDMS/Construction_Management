using RVDMS.Domain.Common;
using RVDMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Entities
{
    public class ProjectAssignment : BaseEntity
    {
        // Foreign keys
        public Guid ProjectId { get; set; }
        public string UserId { get; set; } = null!;
        public UserRole Role { get; set; }
        public DateTime AssignedAt { get; set; }
        public DateTime? RevokedAt { get; set; }

        // Navigation properties
        public virtual Project Project { get; set; } = null!;
        //User navigation property will be handled by Identity
    }
}
