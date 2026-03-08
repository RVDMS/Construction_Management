using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.DTOs
{
    public class UserDto
    {
        public string Id { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public DateTime? LastLoginAt { get; set; }
        public bool IsActive { get; set; }

        public string County { get; set; }

        public string Constituency { get; set; }

        public string Ward { get; set; }

        public string? Role {  get; set; }

        public List<ProjectAssignmentDto> ProjectAssignments {  get; set; } = new List<ProjectAssignmentDto>();
    }
}
