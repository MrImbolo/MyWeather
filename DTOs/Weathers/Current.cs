using System;
using System.Collections.Generic;

namespace DTOs.Weathers
{
    public partial class Current
    {
        private int dt;
        private int sunrise;
        private int sunset;

        public int Dt
        {
            get => dt;
            set
            {
                dt = value;
                DateTime = new DateTime(dt);
            }
        }
        public int Sunrise
        {
            get => sunrise;
            set
            {
                sunrise = value;
                SunriseDT = new DateTime(sunrise);
            }
        }
        public int Sunset
        {
            get => sunset;
            set
            {
                sunset = value;
                SunsetDT = new DateTime(sunset);
            }
        }
        public DateTime SunriseDT { get; private set; }
        public DateTime SunsetDT { get; private set; }
        public DateTime DateTime { get; set; }

        public double Temp { get; set; }
        public double FeelsLike { get; set; }
        public long Pressure { get; set; }
        public long Humidity { get; set; }
        public double DewPoint { get; set; }
        public double Uvi { get; set; }
        public long Clouds { get; set; }
        public long Visibility { get; set; }
        public long WindSpeed { get; set; }
        public long WindDeg { get; set; }
        public List<Weather> Weather { get; set; }
    }
}
