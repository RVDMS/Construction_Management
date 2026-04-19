using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.DTOs
{
    public class ProjectAssignmentDto
    {

        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string? UserPhoneNumber { get; set; }
        public string Role { get; set; } = string.Empty;
        public DateTime AssignedAt { get; set; }
        public DateTime? RevokedAt { get; set; }

        // Location properties from project
        public string? Ward { get; set; }
        public string? Constituency { get; set; }
        public string? County { get; set; }
    }
}
