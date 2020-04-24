using System;

namespace MyWeatherDAL.Types
{
    public struct UnixTime
    {
        public static DateTime Epoch { get => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc); }
        public static DateTime FromUnixTime(long unixTime) => Epoch.AddSeconds(unixTime);
        public static DateTime FromUnixTime(int unixTime) => Epoch.AddSeconds(unixTime);
    }
}
