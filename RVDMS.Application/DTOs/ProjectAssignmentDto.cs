using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.DTOs
{
    public class ProjectAssignmentDto
    {
       
        public string ProjectName { get; set; } = string.Empty;
        public Guid ProjectId { get; set; }
        public string Ward { get; set; } = string.Empty;
        public string Constituency { get; set; } = string.Empty;
        public string County { get; set; } = string.Empty;
    }
}
