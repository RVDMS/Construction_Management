using RVDMS.Domain.Interfaces;
using RVDMS.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Security.Services
{
    public class GeovalidationServices : IGeoValidationService
    {
        public double CalculateDistance(Location loc1, Location loc2)
        {
            return loc1.DistanceTo(loc2);
        }

        public bool IsWithinProjectSite(Location projectLocation, Location userLocation)
        {
            return projectLocation.IsWithinRadius(userLocation.Latitude, userLocation.Longitude);
        }
    }
}
