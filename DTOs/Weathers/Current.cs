using System;
using System.Collections.Generic;

namespace DTOs.Weathers
{
    public partial class Current
    {
        public DateTime Dt { get; set; }
        public DateTime Sunrise { get; set; }
        public DateTime Sunset { get; set; }
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
