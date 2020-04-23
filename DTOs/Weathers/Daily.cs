using System;
using System.Collections.Generic;

namespace DTOs.Weathers
{
    public partial class Daily
    {
        public DateTime Dt { get; set; }
        public DateTime Sunrise { get; set; }
        public DateTime Sunset { get; set; }
        public Temp Temp { get; set; }
        public FeelsLike FeelsLike { get; set; }
        public long Pressure { get; set; }
        public long Humidity { get; set; }
        public double DewPoint { get; set; }
        public double WindSpeed { get; set; }
        public long WindDeg { get; set; }
        public List<Weather> Weather { get; set; }
        public long Clouds { get; set; }
        public double? Rain { get; set; }
        public double Uvi { get; set; }
    }
}
