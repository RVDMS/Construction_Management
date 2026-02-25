using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Common
{
    public abstract class BaseAuditableEntity : BaseEntity
    {
         
        public virtual ICollection<AuditLog> AuditLogs { get; set; }
    }
};

