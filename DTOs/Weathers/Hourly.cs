using System;
using System.Collections.Generic;

namespace DTOs.Weathers
{
    public partial class Hourly
    {
        public DateTime Dt { get; set; }
        public double Temp { get; set; }
        public double FeelsLike { get; set; }
        public long Pressure { get; set; }
        public long Humidity { get; set; }
        public double DewPoint { get; set; }
        public long Clouds { get; set; }
        public double WindSpeed { get; set; }
        public long WindDeg { get; set; }
        public List<Weather> Weather { get; set; }
        public Rain Rain { get; set; }
    }
}
