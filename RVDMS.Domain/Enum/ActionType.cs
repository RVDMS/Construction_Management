using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Enum
{
    public enum ActionType
    {
        Create = 1,
        Update = 2,
        Delete = 3,
        View = 4,
        Login = 5,
        Logout = 6,
        GeoValidation = 7,
        ReportGenerated = 8
    }
}
