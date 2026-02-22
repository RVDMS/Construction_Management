using RVDMS.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.Interfaces
{
    public interface IGeoValidationService
    {
        bool IsWithinProjectSite(Location projectLocation, Location userLocation);
        double CalculateDistance(Location loc1, Location loc2);
    }
}
