using System;
using System.Collections.Generic;
using System.Text;

namespace StructExamples
{
    public struct Location
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public Location(double longitude, double latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public bool IsSame(Location anotherLocation)
        {
            return anotherLocation.Latitude == Latitude
                && anotherLocation.Longitude == Longitude;
        }

        public bool IsSame(double longitude, double latitude)
        {
            return Longitude == longitude && Latitude == latitude;
        }
    }
}
