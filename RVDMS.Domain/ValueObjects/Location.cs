using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Domain.ValueObjects
{
    public class Location : IEquatable<Location>
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public double RadiusInMeters { get; private set; }

        public Location(double latitude, double longitude, double radiusInMeters)
        {
            Latitude = latitude;
            Longitude = longitude;
            RadiusInMeters = radiusInMeters;
        }

        public bool IsWithinRadius(double checklat, double checklng)
        {
            var distance = CalculateDistance(checklat, checklng);
            return distance <= RadiusInMeters;
        }
        private double CalculateDistance(double lat2, double lng2)
        {
            // Haversine formula implementation
            var R = 6371000; // Earth's radius in meters
            var dLat = ToRadians(lat2 - Latitude);
            var dLon = ToRadians(lng2 - Longitude);
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(ToRadians(Latitude)) * Math.Cos(ToRadians(lat2)) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c;
        }

        private double ToRadians(double degrees) => degrees * Math.PI / 180;
        public bool Equals(Location? other)
        {
            return other != null &&
                   Latitude == other.Latitude &&
                   Longitude == other.Longitude &&
                   RadiusInMeters == other.RadiusInMeters;
        }
    }
}
