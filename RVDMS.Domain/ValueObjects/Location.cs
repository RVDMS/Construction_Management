using System;

namespace RVDMS.Domain.ValueObjects
{
    public class Location : IEquatable<Location>
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public double RadiusInMeters { get; private set; }

        public Location(double latitude, double longitude, double radiusInMeters)
        {
            if (latitude < -90 || latitude > 90)
                throw new ArgumentOutOfRangeException(nameof(latitude), "Latitude must be between -90 and 90.");
            if (longitude < -180 || longitude > 180)
                throw new ArgumentOutOfRangeException(nameof(longitude), "Longitude must be between -180 and 180.");
            if (radiusInMeters <= 0)
                throw new ArgumentOutOfRangeException(nameof(radiusInMeters), "Radius must be greater than 0.");

            Latitude = latitude;
            Longitude = longitude;
            RadiusInMeters = radiusInMeters;
        }

        /// <summary>
        /// Checks if the given coordinates are within the radius of this location
        /// </summary>
        public bool IsWithinRadius(double checkLat, double checkLng)
        {
            var distance = CalculateDistance(checkLat, checkLng);
            return distance <= RadiusInMeters;
        }

        /// <summary>
        /// Calculates distance (in meters) to another coordinate using Haversine formula
        /// </summary>
        private double CalculateDistance(double lat2, double lng2)
        {
            const double EarthRadius = 6371000; // meters
            var dLat = ToRadians(lat2 - (double)Latitude);
            var dLon = ToRadians(lng2 - (double)Longitude);

            var lat1Rad = ToRadians((double)Latitude);
            var lat2Rad = ToRadians(lat2);

            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return EarthRadius * c;
        }

        private double ToRadians(double degrees) => degrees * Math.PI / 180;

        /// <summary>
        /// Value-based equality check with tolerance to handle floating point precision
        /// </summary>
        public bool Equals(Location? other)
        {
            if (other == null) return false;
            const double Tolerance = 0.000001; // ~0.11m precision
            return Math.Abs((double)Latitude - (double)other.Latitude) < Tolerance &&
                   Math.Abs((double)Longitude - (double)other.Longitude) < Tolerance &&
                   Math.Abs(RadiusInMeters - other.RadiusInMeters) < 0.01;
        }

        public override bool Equals(object? obj) => Equals(obj as Location);

        public override int GetHashCode()
        {
            return HashCode.Combine(
                Math.Round(Latitude, 6),
                Math.Round(Longitude, 6),
                Math.Round(RadiusInMeters, 2));
        }

        /// <summary>
        /// Optional: calculates distance to another Location object directly
        /// </summary>
        public double DistanceTo(Location other)
        {
            return CalculateDistance((double)other.Latitude, (double)other.Longitude);
        }

        private Location() { } // For EF
    }
}